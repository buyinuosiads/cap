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

namespace Cap.AlarmManagementParent.AlarmManagement
{
    public partial class AlarmManagement : UIPage
    {
        List<Cap_AlarmManagement> dataList = new List<Cap_AlarmManagement>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;

        public AlarmManagement(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("AlarmContent_Manager");
            dataTable.Columns.Add("AlarmCause_Manager");
            dataTable.Columns.Add("WhetherTimelyProcessing_Manager");
            dataTable.Columns.Add("Createtime_Manager");
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
            Expression<Func<Cap_AlarmManagement, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(AlarmContent.Text))
            {
                where = ExpressionBuilder.And(where, f => f.AlarmContent.Contains(AlarmContent.Text));
            };

            dataList.Clear();
            List<Cap_AlarmManagement> sys_Users = capProjectDb.Cap_AlarmManagement.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in sys_Users)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = sys_Users.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AlarmContent, dataList[i].AlarmCause, dataList[i].WhetherTimelyProcessing, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void AlarmManagement_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AlarmContent, dataList[i].AlarmCause, dataList[i].WhetherTimelyProcessing, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
            //string rowData = row.Cells["Column1"].Value.ToString();
            //string Column3 = row.Cells["Column2"].Value.ToString();
            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    AlarmManagementEdit order = new AlarmManagementEdit(Column2, rowData, Column3);///实例化窗体
            //    order.ShowDialog();
            //}
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    AlarmManagementEdit order = new AlarmManagementEdit(Column2, rowData, Column3);///实例化窗体
            //    order.ShowDialog();
            //}


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {

                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Cap_AlarmManagement cap_AlarmManagement = capProjectDb.Cap_AlarmManagement.Where(t => t.Id == Id_Manager).FirstOrDefault();
                    cap_AlarmManagement.IsDelete = 99;
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
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Cap_AlarmManagement cap_AlarmManagement = new Cap_AlarmManagement();
                cap_AlarmManagement.Id = Guid.NewGuid().ToString();
                cap_AlarmManagement.AlarmContent = AlarmContent.Text;
                cap_AlarmManagement.AlarmCause = AlarmCause.Text;
                cap_AlarmManagement.WhetherTimelyProcessing = WhetherTimelyProcessing.Text;
                cap_AlarmManagement.CreateTime = DateTime.Now;
                cap_AlarmManagement.CreateName = _Name;
                cap_AlarmManagement.IsDelete = 0;
                capProjectDb.Cap_AlarmManagement.InsertOnSubmit(cap_AlarmManagement);
                capProjectDb.SubmitChanges();
                ShowSuccessTip("添加成功");
                uiButton6_Click(sender, e); //调用清空文本框方法
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
                string AlarmContent_Manager = row.Cells["AlarmContent_Manager"].Value.ToString();
                string AlarmCause_Manager = row.Cells["AlarmCause_Manager"].Value.ToString();
                string WhetherTimelyProcessing_Manager = row.Cells["WhetherTimelyProcessing_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["Createtime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();

                Id = Id_Manager;
                AlarmContent.Text = AlarmContent_Manager;
                AlarmCause.Text = AlarmCause_Manager;
                WhetherTimelyProcessing.Text = WhetherTimelyProcessing_Manager;
                CreateName.Text = CreateName_Manager;
                CreateTime.Text = CreateTime_Manager;
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
            AlarmContent.Text = null;
            AlarmCause.Text = null;
            CreateName.Text = null;
            CreateTime.Text = null;
            WhetherTimelyProcessing.Text = null;
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
                Cap_AlarmManagement cap_AlarmManagement = capProjectDb.Cap_AlarmManagement.Where(t => t.Id == Id).FirstOrDefault();
                cap_AlarmManagement.AlarmContent = AlarmContent.Text;
                cap_AlarmManagement.AlarmCause = AlarmCause.Text;
                cap_AlarmManagement.WhetherTimelyProcessing = WhetherTimelyProcessing.Text;
                cap_AlarmManagement.CreateName = CreateName.Text;
                capProjectDb.SubmitChanges();
                ShowSuccessTip("修改成功");
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
