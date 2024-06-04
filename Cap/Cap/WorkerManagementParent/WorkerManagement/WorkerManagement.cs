using Cap.BasicSettings.Accessories;
using Cap.Order.OrderSplitting;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.WorkerManagementParent.WorkerManagement
{
    public partial class WorkerManagement : UIPage
    {
        List<Cap_WorkerManagement> dataList = new List<Cap_WorkerManagement>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public WorkerManagement(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("NameOfWorker_Manager");
            dataTable.Columns.Add("Message_Manager");
            dataTable.Columns.Add("BasicInformation_Manager");
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
            Expression<Func<Cap_WorkerManagement, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(NameOfWorker.Text))
            {
                where = ExpressionBuilder.And(where, f => f.NameOfWorker.Contains(NameOfWorker.Text));
            };
            dataList.Clear();
            List<Cap_WorkerManagement> outbounds = capProjectDb.Cap_WorkerManagement.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfWorker, dataList[i].Message, dataList[i].BasicInformation, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }



        private void WorkerManagement_Initialize(object sender, EventArgs e)
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfWorker, dataList[i].Message, dataList[i].BasicInformation, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();

            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    WorkerManagementEdit order = new WorkerManagementEdit(rowData, Column2, Column3);///实例化窗体
            //    order.ShowDialog();
            //}


            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    WorkerManagementEdit order = new WorkerManagementEdit(rowData, Column2, Column3);///实例化窗体
            //    order.ShowDialog();
            //}


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {

                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Cap_WorkerManagement stocks = capProjectDb.Cap_WorkerManagement.Where(t => t.Id == Id_Manager).FirstOrDefault();
                    stocks.IsDelete = 99;
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要添加吗？"))
            {
                if (string.IsNullOrEmpty(NameOfWorker.Text))
                {
                    ShowWarningDialog("工人名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Message.Text))
                {
                    ShowWarningDialog("基本信息不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(BasicInformation.Text))
                {
                    ShowWarningDialog("工艺信息不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Cap_WorkerManagement cap_WorkerManagement = new Cap_WorkerManagement();
                cap_WorkerManagement.Id = Guid.NewGuid().ToString();
                cap_WorkerManagement.NameOfWorker = NameOfWorker.Text;
                cap_WorkerManagement.Message = Message.Text;
                cap_WorkerManagement.BasicInformation = BasicInformation.Text;
                cap_WorkerManagement.CreateTime = DateTime.Now;
                cap_WorkerManagement.CreateName = _Name;
                cap_WorkerManagement.IsDelete = 0;
                //保存数据
                capProjectDb.Cap_WorkerManagement.InsertOnSubmit(cap_WorkerManagement);
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
        /// 查看
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
            string NameOfWorker_Manager = row.Cells["NameOfWorker_Manager"].Value.ToString();
            string Message_Manager = row.Cells["Message_Manager"].Value.ToString();
            string BasicInformation_Manager = row.Cells["BasicInformation_Manager"].Value.ToString();
            string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
            string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
            Id = Id_Manager;
            NameOfWorker.Text = NameOfWorker_Manager;
            Message.Text = Message_Manager;
            BasicInformation.Text = BasicInformation_Manager;
            CreateTime.Text = CreateTime_Manager;
            CreateName.Text = CreateName_Manager;

        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            NameOfWorker.Text = null;
            Message.Text = null;
            BasicInformation.Text = null;
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

                if (string.IsNullOrEmpty(NameOfWorker.Text))
                {
                    ShowWarningDialog("工人名称不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(Message.Text))
                {
                    ShowWarningDialog("基本信息不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(BasicInformation.Text))
                {
                    ShowWarningDialog("工艺信息不能为空");
                    return;
                }
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Cap_WorkerManagement cap_WorkerManagement = capProjectDb.Cap_WorkerManagement.Where(t => t.Id == Id).FirstOrDefault();
                cap_WorkerManagement.Id = Guid.NewGuid().ToString();
                cap_WorkerManagement.NameOfWorker = NameOfWorker.Text;
                cap_WorkerManagement.Message = Message.Text;
                cap_WorkerManagement.BasicInformation = BasicInformation.Text;
                cap_WorkerManagement.IsDelete = 0;
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
