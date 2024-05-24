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

namespace Cap.Finance.FinancialJournal
{
    public partial class FinancialJournal : UIPage
    {
        List<Cap_FinancialDailyAccount> dataList = new List<Cap_FinancialDailyAccount>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public FinancialJournal(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("FinancialJournal_Manager");
            dataTable.Columns.Add("FixedAssets_Manager");
            dataTable.Columns.Add("OtherPurchases_Manager");
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
            Expression<Func<Cap_FinancialDailyAccount, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(FinancialJournal_RZ.Text))
            {
                where = ExpressionBuilder.And(where, f => f.FinancialJournal.Contains(FinancialJournal_RZ.Text));
            };

            dataList.Clear();
            List<Cap_FinancialDailyAccount> cap_Financials = capProjectDb.Cap_FinancialDailyAccount.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].FinancialJournal, dataList[i].FixedAssets, dataList[i].OtherPurchases, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].FinancialJournal, dataList[i].FixedAssets, dataList[i].OtherPurchases, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void FinancialJournal_Initialize_1(object sender, EventArgs e)
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

                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    FinancialJournalEdit order = new FinancialJournalEdit(rowData, Column2, Column3);///实例化窗体
                //    order.ShowDialog();
                //}
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    FinancialJournalEdit order = new FinancialJournalEdit(rowData, Column2, Column3);///实例化窗体
                //    order.ShowDialog();
                //}


                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Cap_FinancialDailyAccount cap_FinancialDailyAccount = capProjectDb.Cap_FinancialDailyAccount.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        cap_FinancialDailyAccount.IsDelete = 99;
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
                Cap_FinancialDailyAccount cap_FinancialDaily = new Cap_FinancialDailyAccount();
                cap_FinancialDaily.Id = Guid.NewGuid().ToString();
                cap_FinancialDaily.FinancialJournal = FinancialJournal_RZ.Text;
                cap_FinancialDaily.FixedAssets = FixedAssets.Text;
                cap_FinancialDaily.OtherPurchases = OtherPurchases.Text;
                cap_FinancialDaily.CreateTime = DateTime.Now;
                cap_FinancialDaily.CreateName = _Name;
                cap_FinancialDaily.IsDelete = 0;
                //添加数据
                capProjectDb.Cap_FinancialDailyAccount.InsertOnSubmit(cap_FinancialDaily);
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
                string FinancialJournal_Manager = row.Cells["FinancialJournal_Manager"].Value.ToString();
                string FixedAssets_Manager = row.Cells["FixedAssets_Manager"].Value.ToString();
                string OtherPurchases_Manager = row.Cells["OtherPurchases_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();

                Id = Id_Manager;
                FinancialJournal_RZ.Text = FinancialJournal_Manager;
                FixedAssets.Text = FixedAssets_Manager;
                OtherPurchases.Text = OtherPurchases_Manager;
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
            FinancialJournal_RZ.Text = null;
            FixedAssets.Text = null;
            OtherPurchases.Text = null;
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
                Cap_FinancialDailyAccount cap_Financial = capProjectDb.Cap_FinancialDailyAccount.Where(t => t.Id == Id).FirstOrDefault();
                cap_Financial.FinancialJournal = FinancialJournal_RZ.Text;
                cap_Financial.FixedAssets = FixedAssets.Text;
                cap_Financial.OtherPurchases = OtherPurchases.Text; 
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
