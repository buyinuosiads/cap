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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.WorkRecordsParent.WorkRecords
{
    public partial class WorkRecords : UIPage
    {

        List<Cap_WorkRecord> dataList = new List<Cap_WorkRecord>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = null;
        string _Name = string.Empty;
        public WorkRecords(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("JobTitle_Manager");
            dataTable.Columns.Add("Logging_Manager");
            dataTable.Columns.Add("Statistics_Manager");
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
            Expression<Func<Cap_WorkRecord, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(JobTitle.Text))
            {
                where = ExpressionBuilder.And(where, f => f.JobTitle.Contains(JobTitle.Text));
            };


            dataList.Clear();
            List<Cap_WorkRecord> cap_WorkRecords = capProjectDb.Cap_WorkRecord.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in cap_WorkRecords)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = cap_WorkRecords.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].JobTitle, dataList[i].Logging, dataList[i].Statistics, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }



        private void WorkRecords_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].JobTitle, dataList[i].Logging, dataList[i].Statistics, dataList[i].CreateTime, dataList[i].CreateName);
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
                //string Column2 = row.Cells["FullBoxCount"].Value.ToString();
                //string Column3 = row.Cells["ConsumablesCount"].Value.ToString();


                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    WorkRecordsEdit order = new WorkRecordsEdit(rowData, Column2, Column3);///实例化窗体
                //    order.ShowDialog();
                //}
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    WorkRecordsEdit order = new WorkRecordsEdit(rowData, Column2, Column3);///实例化窗体
                //    order.ShowDialog();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Cap_WorkRecord cap_Work = capProjectDb.Cap_WorkRecord.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        cap_Work.IsDelete = 99;
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
                if (string.IsNullOrEmpty(JobTitle.Text))
                {
                    ShowWarningDialog("工作名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Logging.Text))
                {
                    ShowWarningDialog("工作记录不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Statistics.Text))
                {
                    ShowWarningDialog("统计不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Cap_WorkRecord cap_Work = new Cap_WorkRecord();
                cap_Work.Id = Guid.NewGuid().ToString();
                cap_Work.JobTitle = JobTitle.Text;
                cap_Work.Logging = Logging.Text;
                cap_Work.Statistics = Statistics.Text;
                cap_Work.CreateTime = DateTime.Now;
                cap_Work.CreateName = _Name;
                cap_Work.IsDelete = 0;
                //添加数据
                capProjectDb.Cap_WorkRecord.InsertOnSubmit(cap_Work);
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
                string JobTitle_Manager = row.Cells["JobTitle_Manager"].Value.ToString();
                string Logging_Manager = row.Cells["Logging_Manager"].Value.ToString();
                string Statistics_Manager = row.Cells["Statistics_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                JobTitle.Text = JobTitle_Manager;
                Logging.Text = Logging_Manager;
                Statistics.Text = Statistics_Manager;
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
            JobTitle.Text = null;
            Logging.Text = null;
            Statistics.Text = null;
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
                Cap_WorkRecord cap_Work = capProjectDb.Cap_WorkRecord.Where(t => t.Id == Id).FirstOrDefault();
                cap_Work.JobTitle = JobTitle.Text;
                cap_Work.Logging = Logging.Text;
                cap_Work.Statistics = Statistics.Text;
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
