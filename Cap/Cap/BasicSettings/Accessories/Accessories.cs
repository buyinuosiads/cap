using Cap.AttendanceManagementParent.AttendanceManagement;
using Cap.BasicSettings.Ingredients;
using Model;
using Sunny.UI;
using Sunny.UI.Win32;
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

namespace Cap.BasicSettings.Accessories
{
    public partial class Accessories : UIPage
    {
        List<ChargeTime> dataList = new List<ChargeTime>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public Accessories()
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("AccessoryName_Manager");
            dataTable.Columns.Add("Unit_Manager");
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
            Expression<Func<ChargeTime, bool>> where = s => s.Id != null && s.IsDelete == 0;

            if (!string.IsNullOrEmpty(AccessoryName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.AccessoryName.Contains(AccessoryName.Text));
            }

            dataList.Clear();
            List<ChargeTime> chargeTimes = capProjectDb.ChargeTime.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in chargeTimes)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = chargeTimes.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AccessoryName, dataList[i].Unit, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AccessoryName, dataList[i].Unit, dataList[i].CreateTime, dataList[i].CreateName);
            }
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
                string AccessoryName_Manager = row.Cells["AccessoryName_Manager"].Value.ToString();
                string Unit_Manager = row.Cells["Unit_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();



                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    AccessoriesEdit frm = new AccessoriesEdit(Column1, Column2);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}
                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    AccessoriesEdit frm = new AccessoriesEdit(Column1, Column2);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}


                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        ShowSuccessTip("删除成功");
                        uiDataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        ShowErrorTip("取消当前操作");
                    }
                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要添加吗？"))
            {
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                ChargeTime chargeTime = new ChargeTime();
                chargeTime.Id = Guid.NewGuid().ToString();
                chargeTime.AccessoryName = AccessoryName.Text;
                chargeTime.Unit = Unit.Text;
                chargeTime.CreateTime = DateTime.Now;
                chargeTime.CreateName = CreateName.Text;
                chargeTime.IsDelete = 0;
                //保存数据
                capProjectDb.ChargeTime.InsertOnSubmit(chargeTime);
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

        private void Accessories_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
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
                string AccessoryName_Manager = row.Cells["AccessoryName_Manager"].Value.ToString();
                string Unit_Manager = row.Cells["Unit_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                AccessoryName.Text = AccessoryName_Manager;
                Unit.Text = Unit_Manager;
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
            AccessoryName.Text = null;
            Unit.Text = null;
            CreateName.Text = null;
            CreateTime.Text = null;
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
                ChargeTime chargeTime = capProjectDb.ChargeTime.Where(t => t.Id == Id).FirstOrDefault();
                chargeTime.AccessoryName = AccessoryName.Text;
                chargeTime.Unit = Unit.Text;
                chargeTime.CreateName = CreateName.Text;
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
