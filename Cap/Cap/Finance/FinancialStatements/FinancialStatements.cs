using Cap.AlarmManagementParent.AlarmManagement;
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

namespace Cap.Finance.FinancialStatements
{
    public partial class FinancialStatements : UIPage
    {
        List<Cap_FinancialStatements> dataList = new List<Cap_FinancialStatements>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public FinancialStatements()
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("OrderNumber_Manager");
            dataTable.Columns.Add("NameOfMaterial_Manager");
            dataTable.Columns.Add("MaterialPrice_Manager");
            dataTable.Columns.Add("QuantityOfMaterial_Manager");
            dataTable.Columns.Add("GrossAmount_Manager");
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
            Expression<Func<Cap_FinancialStatements, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(OrderNumber.Text))
            {
                where = ExpressionBuilder.And(where, f => f.OrderNumber.Contains(OrderNumber.Text));
            };
            dataList.Clear();
            List<Cap_FinancialStatements> cap_Financials = capProjectDb.Cap_FinancialStatements.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in cap_Financials)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = cap_Financials.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OrderNumber, dataList[i].NameOfMaterial, dataList[i].MaterialPrice, dataList[i].QuantityOfMaterial, dataList[i].GrossAmount, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }

        private void FinancialStatements_Initialize(object sender, EventArgs e)
        {

            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].OrderNumber, dataList[i].NameOfMaterial, dataList[i].MaterialPrice, dataList[i].QuantityOfMaterial, dataList[i].GrossAmount, dataList[i].CreateTime, dataList[i].CreateName);
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

                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    FinancialStatementsEdit order = new FinancialStatementsEdit(rowData, Column2, Column3, Column4, Column5);///实例化窗体
                //    order.ShowDialog();
                //}
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    FinancialStatementsEdit order = new FinancialStatementsEdit(rowData, Column2, Column3, Column4, Column5);///实例化窗体
                //    order.ShowDialog();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Cap_FinancialStatements sys_User = capProjectDb.Cap_FinancialStatements.Where(t => t.Id == Id_Manager).FirstOrDefault();
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
                Cap_FinancialStatements cap_Financial = new Cap_FinancialStatements();
                cap_Financial.Id = Guid.NewGuid().ToString();
                cap_Financial.OrderNumber = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                cap_Financial.NameOfMaterial = NameOfMaterial.Text;
                cap_Financial.MaterialPrice = decimal.Parse(MaterialPrice.Text);
                cap_Financial.QuantityOfMaterial = QuantityOfMaterial.Text;
                cap_Financial.GrossAmount = decimal.Parse(GrossAmount.Text);
                cap_Financial.CreateTime = DateTime.Now;
                cap_Financial.CreateName = CreateName.Text;
                cap_Financial.IsDelete = 0;
                //添加数据
                capProjectDb.Cap_FinancialStatements.InsertOnSubmit(cap_Financial);
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
                string OrderNumber_Manager = row.Cells["OrderNumber_Manager"].Value.ToString();
                string NameOfMaterial_Manager = row.Cells["NameOfMaterial_Manager"].Value.ToString();
                string MaterialPrice_Manager = row.Cells["MaterialPrice_Manager"].Value.ToString();
                string QuantityOfMaterial_Manager = row.Cells["QuantityOfMaterial_Manager"].Value.ToString();
                string GrossAmount_Manager = row.Cells["GrossAmount_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                OrderNumber.Text = OrderNumber_Manager;
                NameOfMaterial.Text = NameOfMaterial_Manager;
                MaterialPrice.Text = MaterialPrice_Manager;
                QuantityOfMaterial.Text = QuantityOfMaterial_Manager;
                GrossAmount.Text = GrossAmount_Manager;
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
            OrderNumber.Text = null;
            NameOfMaterial.Text = null;
            MaterialPrice.Text = "0.00";
            QuantityOfMaterial.Text = null;
            GrossAmount.Text = "0.00";
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
                Cap_FinancialStatements cap_Financial = capProjectDb.Cap_FinancialStatements.Where(t => t.Id == Id).FirstOrDefault();
                //cap_Financial.OrderNumber = OrderNumber.Text;
                cap_Financial.NameOfMaterial = NameOfMaterial.Text;
                cap_Financial.MaterialPrice = decimal.Parse(MaterialPrice.Text);
                cap_Financial.QuantityOfMaterial = QuantityOfMaterial.Text;
                cap_Financial.GrossAmount = decimal.Parse(GrossAmount.Text);
                cap_Financial.CreateName = CreateName.Text;
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

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }
    }
}
