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

namespace Cap.Order.OrderManagement
{
    public partial class OrderManagement : UIPage
    {
        List<Cap_OrderManagement> dataList = new List<Cap_OrderManagement>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public OrderManagement(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("ProductManagement_Manager");
            dataTable.Columns.Add("Quantity_Manager");
            dataTable.Columns.Add("Customer_Manager");
            dataTable.Columns.Add("Schedule_Manager");
            dataTable.Columns.Add("State_Manager");
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
            Expression<Func<Cap_OrderManagement, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(ProductManagement.Text))
            {
                where = ExpressionBuilder.And(where, f => f.ProductManagement.Contains(ProductManagement.Text));
            };
            dataList.Clear();
            List<Cap_OrderManagement> outbounds = capProjectDb.Cap_OrderManagement.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProductManagement, dataList[i].Quantity, dataList[i].Customer, dataList[i].Schedule, dataList[i].State, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProductManagement, dataList[i].Quantity, dataList[i].Customer, dataList[i].Schedule, dataList[i].State, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void OrderManagement_Initialize(object sender, EventArgs e)
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

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
            //string Column1 = row.Cells["SupplierName"].Value.ToString();
            //string Column2 = row.Cells["FullBoxCount"].Value.ToString();
            //string Column3 = row.Cells["ConsumablesCount"].Value.ToString();

            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    OrderManagementEdit frm = new OrderManagementEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}


            //// 确保点击的是按钮列
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    OrderManagementEdit frm = new OrderManagementEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Cap_OrderManagement sys_User = capProjectDb.Cap_OrderManagement.Where(t => t.Id == Id_Manager).FirstOrDefault();
                    sys_User.IsDelete = 99;
                    capProjectDb.SubmitChanges();
                    ShowSuccessTip("删除成功");
                    uiButton6_Click(sender, e); //调用清空文本框方法
                    GetList();
                }
                else
                {
                    ShowErrorTip("取消当前操作");
                }
            }
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("确定要添加吗？"))
            {

                if (string.IsNullOrEmpty(ProductManagement.Text))
                {
                    ShowWarningDialog("产品信息不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Quantity.Text))
                {
                    ShowWarningDialog("数量不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Customer.Text))
                {
                    ShowWarningDialog("客户不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Schedule.Text))
                {
                    ShowWarningDialog("进度不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(State.Text))
                {
                    ShowWarningDialog("状态不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Cap_OrderManagement outbound = new Cap_OrderManagement();
                outbound.Id = Guid.NewGuid().ToString();
                outbound.ProductManagement = ProductManagement.Text;
                outbound.Quantity = Quantity.Text;
                outbound.Customer = Customer.Text;
                outbound.Schedule = Schedule.Text;
                outbound.State = State.Text;
                outbound.CreateName = _Name;
                outbound.IsDelete = 0;
                capProjectDb.Cap_OrderManagement.InsertOnSubmit(outbound);
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
                string ProductManagement_Manager = row.Cells["ProductManagement_Manager"].Value.ToString();
                string Quantity_Manager = row.Cells["Quantity_Manager"].Value.ToString();
                string Customer_Manager = row.Cells["Customer_Manager"].Value.ToString();
                string Schedule_Manager = row.Cells["Schedule_Manager"].Value.ToString();
                string State_Manager = row.Cells["State_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                ProductManagement.Text = ProductManagement_Manager;
                Quantity.Text = Quantity_Manager;
                Customer.Text = Customer_Manager;
                Schedule.Text = Schedule_Manager;
                State.Text = State_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;
            }
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
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            ProductManagement.Text = null;
            Quantity.Text = null;
            Customer.Text = null;
            Schedule.Text = null;
            State.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
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
                Cap_OrderManagement outbound = capProjectDb.Cap_OrderManagement.Where(t => t.Id == Id).FirstOrDefault();
                outbound.ProductManagement = ProductManagement.Text;
                outbound.Quantity = Quantity.Text;
                outbound.Customer = Customer.Text;
                outbound.Schedule = Schedule.Text;
                outbound.State = State.Text;
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
