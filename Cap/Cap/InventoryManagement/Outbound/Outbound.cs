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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.InventoryManagement.Outbound
{
    public partial class Outbound : UIPage
    {
        List<OutboundManager> dataList = new List<OutboundManager>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public Outbound()
        {
            InitializeComponent();
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("OutboundName_Manager");
            dataTable.Columns.Add("Contact_Manager");
            dataTable.Columns.Add("Phone_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");
            GetList();
        }



        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<OutboundManager, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(OutboundName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.OutboundName.Contains(OutboundName.Text));
            };
            dataList.Clear();
            List<OutboundManager> outbounds = capProjectDb.OutboundManager.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in outbounds)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = outbounds.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OutboundName, dataList[i].Contact, dataList[i].Phone, dataList[i].CreateTime, dataList[i].CreateName);
            }
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OutboundName, dataList[i].Contact, dataList[i].Phone, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }



        private void Outbound_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
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

                //    OutboundEdit frm = new OutboundEdit(Column1, Column2, Column3, Column4);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{

                //    OutboundEdit frm = new OutboundEdit(Column1, Column2, Column3, Column4);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}


                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        OutboundManager bePutInStorage = capProjectDb.OutboundManager.Where(t => t.Id == Id_Manager).FirstOrDefault();
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

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                OutboundManager outbound = new OutboundManager();
                outbound.Id = Guid.NewGuid().ToString();
                outbound.OutboundName = OutboundName.Text;
                outbound.Contact = Contact.Text; ;
                outbound.Phone = Phone.Text;
                outbound.CreateName = CreateName.Text;
                outbound.CreateTime = DateTime.Now;
                outbound.IsDelete = 0;
                //添加数据
                capProjectDb.OutboundManager.InsertOnSubmit(outbound);
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
                string OutboundName_Manager = row.Cells["OutboundName_Manager"].Value.ToString();
                string Contact_Manager = row.Cells["Contact_Manager"].Value.ToString();
                string Phone_Manager = row.Cells["Phone_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                OutboundName.Text = OutboundName_Manager;
                Contact.Text = Contact_Manager;
                Phone.Text = Phone_Manager;
                CreateName.Text = CreateTime_Manager;
                CreateTime.Text = CreateName_Manager;
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
            OutboundName.Text = null;
            Contact.Text = null;
            Phone.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
        }

        /// <summary>
        /// 查询
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
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                OutboundManager outbound = capProjectDb.OutboundManager.Where(t => t.Id == Id).FirstOrDefault();
                outbound.OutboundName = OutboundName.Text;
                outbound.Contact = Contact.Text; ;
                outbound.Phone = Phone.Text;
                outbound.CreateName = CreateName.Text;
                outbound.IsDelete = 0;
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