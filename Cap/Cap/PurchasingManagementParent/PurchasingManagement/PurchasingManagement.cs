using Cap.BasicSettings.Accessories;
using Cap.Order.OrderSplitting;
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
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.PurchasingManagementParent.PurchasingManagement
{
    public partial class PurchasingManagement : UIPage
    {
        List<Cap_PurchasingManagement> dataList = new List<Cap_PurchasingManagement>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;

        public PurchasingManagement(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("OrderNumber_Manager");
            dataTable.Columns.Add("OrderQuantity_Manager");
            dataTable.Columns.Add("OrderName_Manager");
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
            Expression<Func<Cap_PurchasingManagement, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(OrderNumber.Text))
            {
                where = ExpressionBuilder.And(where, f => f.OrderNumber.Contains(OrderNumber.Text));
            };

            dataList.Clear();
            List<Cap_PurchasingManagement> cap_Purchasings = capProjectDb.Cap_PurchasingManagement.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in cap_Purchasings)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = cap_Purchasings.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OrderNumber, dataList[i].OrderQuantity, dataList[i].OrderName, dataList[i].CreateTime, dataList[i].CreateName);
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
            //未连接数据库，通过模拟数据来实现
            //一般通过ORM的分页去取数据来填充
            //pageIndex：第几页，和界面对应，从1开始，取数据可能要用pageIndex - 1
            //count：单页数据量，也就是PageSize值

            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OrderNumber, dataList[i].OrderQuantity, dataList[i].OrderName, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }




        private void PurchasingManagement_Initialize(object sender, EventArgs e)
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
            //string Column2 = row.Cells["FullBoxCount"].Value.ToString();
            //string Column3 = row.Cells["ConsumablesCount"].Value.ToString();

            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    PurchasingManagementEdit order = new PurchasingManagementEdit(rowData, Column2, Column3);///实例化窗体
            //    order.ShowDialog();
            //}

            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    PurchasingManagementEdit order = new PurchasingManagementEdit(rowData, Column2, Column3);///实例化窗体
            //    order.ShowDialog();
            //}


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {

                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Cap_PurchasingManagement cap_PurchasingManagement = capProjectDb.Cap_PurchasingManagement.Where(t => t.Id == Id_Manager).FirstOrDefault();
                    cap_PurchasingManagement.IsDelete = 99;
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
                Cap_PurchasingManagement cap_PurchasingManagement = new Cap_PurchasingManagement();
                cap_PurchasingManagement.Id = Guid.NewGuid().ToString();
                cap_PurchasingManagement.OrderNumber = DateTime.Now.ToString("yyyyMMddHHmmssfff");  //订单号
                cap_PurchasingManagement.OrderQuantity = int.Parse(OrderQuantity.Text);
                cap_PurchasingManagement.OrderName = OrderName.Text;
                cap_PurchasingManagement.CreateTime = DateTime.Now;
                cap_PurchasingManagement.CreateName = _Name;
                cap_PurchasingManagement.IsDelete = 0;
                //保存数据
                capProjectDb.Cap_PurchasingManagement.InsertOnSubmit(cap_PurchasingManagement);
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
                string OrderNumber_Manager = row.Cells["OrderNumber_Manager"].Value.ToString();
                string OrderQuantity_Manager = row.Cells["OrderQuantity_Manager"].Value.ToString();
                string OrderName_Manager = row.Cells["OrderName_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();

                Id = Id_Manager;
                OrderNumber.Text = OrderNumber_Manager;
                OrderQuantity.Text = OrderQuantity_Manager;
                OrderName.Text = OrderName_Manager;
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
            OrderNumber.Text = null;
            OrderQuantity.Text = null;
            OrderName.Text = null;
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
                Cap_PurchasingManagement cap_PurchasingManagement = capProjectDb.Cap_PurchasingManagement.Where(t => t.Id == Id).FirstOrDefault();
                cap_PurchasingManagement.OrderQuantity = int.Parse(OrderQuantity.Text);
                cap_PurchasingManagement.OrderName = OrderName.Text;
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
    }
}