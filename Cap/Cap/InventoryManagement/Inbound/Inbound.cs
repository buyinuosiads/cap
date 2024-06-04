using Cap.BasicSettings.Accessories;
using Cap.InventoryManagement.Inventory;
using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.InventoryManagement.Inbound
{
    public partial class Inbound : UIPage
    {
        List<BePutInStorage> dataList = new List<BePutInStorage>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = null;
        string _Name = string.Empty;
        public Inbound(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("IncomingName_Manager");
            dataTable.Columns.Add("Contact_Manager");
            dataTable.Columns.Add("Phone_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");

            GetList();
            _Name = name;
        }


        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<BePutInStorage, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(IncomingName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.IncomingName.Contains(IncomingName.Text));
            };


            dataList.Clear();
            List<BePutInStorage> bePutInStorages = capProjectDb.BePutInStorage.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in bePutInStorages)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = bePutInStorages.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].IncomingName, dataList[i].Contact, dataList[i].Phone, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }




        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }



        /// <summary>
        /// 分页控件页面切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].IncomingName, dataList[i].Contact, dataList[i].Phone, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void Inbound_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();

                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    InboundEdit frm = new InboundEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    InboundEdit frm = new InboundEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        BePutInStorage bePutInStorage = capProjectDb.BePutInStorage.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        bePutInStorage.IsDelete = 99;
                        //保存数据
                        capProjectDb.SubmitChanges();
                        ShowSuccessTip("删除成功");
                        uiButton6_Click(sender, e); //调用清空文本框方法
                                                    //查询数据
                        GetList();

                    }
                    else
                    {
                        ShowErrorTip("取消当前操作");
                    }
                }
            }
        }



        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要添加吗？"))
            {
                if (string.IsNullOrEmpty(IncomingName.Text))
                {
                    ShowWarningDialog("入库名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Contact.Text))
                {
                    ShowWarningDialog("联系人不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Phone.Text))
                {
                    ShowWarningDialog("联系电话不能为空");
                    return;
                }


                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                BePutInStorage bePutInStorage = new BePutInStorage();
                bePutInStorage.Id = Guid.NewGuid().ToString();
                bePutInStorage.IncomingName = IncomingName.Text;
                bePutInStorage.Contact = Contact.Text;
                bePutInStorage.Phone = Phone.Text;
                bePutInStorage.CreateTime = DateTime.Now;
                bePutInStorage.CreateName = _Name;
                bePutInStorage.IsDelete = 0;
                //添加数据
                capProjectDb.BePutInStorage.InsertOnSubmit(bePutInStorage);
                //保存数据
                capProjectDb.SubmitChanges();
                ShowSuccessDialog("添加成功");
                uiButton6_Click(sender, e); //调用清空文本框方法
                                            //查询数据
                GetList();
            }
            else
            {
                ShowErrorTip("取消当前操作");
            }

        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string IncomingName_Manager = row.Cells["IncomingName_Manager"].Value.ToString();
                string Contact_Manager = row.Cells["Contact_Manager"].Value.ToString();
                string Phone_Manager = row.Cells["Phone_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                IncomingName.Text = IncomingName_Manager;
                Contact.Text = Contact_Manager;
                Phone.Text = Phone_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;
            }
        }


        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            IncomingName.Text = null;
            Contact.Text = null;
            Phone.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("确定要修改吗？"))
            {

                if (string.IsNullOrEmpty(IncomingName.Text))
                {
                    ShowWarningDialog("入库名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Contact.Text))
                {
                    ShowWarningDialog("联系人不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Phone.Text))
                {
                    ShowWarningDialog("联系电话不能为空");
                    return;
                }
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                BePutInStorage bePutInStorage = capProjectDb.BePutInStorage.Where(t => t.Id == Id).FirstOrDefault();
                bePutInStorage.IncomingName = IncomingName.Text;
                bePutInStorage.Contact = Contact.Text;
                bePutInStorage.Phone = Phone.Text;
                bePutInStorage.CreateName = CreateName.Text;
                //保存数据
                capProjectDb.SubmitChanges();
                ShowSuccessDialog("修改成功");
                uiButton6_Click(sender, e); //调用清空文本框方法
                                            //查询数据
                GetList();

            }
            else
            {
                ShowErrorTip("取消当前操作");
            }


        }
    }
}
