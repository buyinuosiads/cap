using Model;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.SystemSetup.AlarmSetting
{
    public partial class AlarmSetting : UIPage
    {
        List<Alarm_Setting> dataList = new List<Alarm_Setting>();
        DataTable dataTable = new DataTable("DataTable");

        string Id = null;

        public AlarmSetting()
        {
            InitializeComponent();
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("WarningMessage_Manager");
            dataTable.Columns.Add("Processvalue_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            GetList();
        }





        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<Alarm_Setting, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(Message.Text))
            {
                where = ExpressionBuilder.And(where, f => f.WarningMessage.Contains(Message.Text));
            };
            if (!string.IsNullOrEmpty(Processvalue.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Processvalue == int.Parse(Processvalue.Text));
            }

            dataList.Clear();
            List<Alarm_Setting> sys_Users = capProjectDb.Alarm_Setting.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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

                dataTable.Rows.Add(dataList[i].Id, dataList[i].WarningMessage, dataList[i].Processvalue, dataList[i].CreateTime);
            }
        }




        private void AlarmSetting_Initialize(object sender, EventArgs e)
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




        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {

            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].WarningMessage, dataList[i].Processvalue, dataList[i].CreateTime);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string WarningMessage_Manager = row.Cells["WarningMessage_Manager"].Value.ToString();
                string Processvalue_Manager = row.Cells["Processvalue_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();


                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    AlarmSettingDetail companySearchDetail = new AlarmSettingDetail(rowData);///实例化窗体
                //    companySearchDetail.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                //    companySearchDetail.ShowDialog();///显示窗体 
                //}


                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    AlarmSettingEdit commpanyEdit = new AlarmSettingEdit(rowData);///实例化窗体
                //    commpanyEdit.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                //    commpanyEdit.ShowDialog();///显示窗体 
                //}


                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {

                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Alarm_Setting alarm_Setting = capProjectDb.Alarm_Setting.Where(t => t.Id == Id).FirstOrDefault();
                        alarm_Setting.IsDelete = 99;
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
        private void uiSymbolButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Message.Text))
            {
                ShowWarningDialog("告警信息不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(Processvalue.Text))
            {
                ShowWarningDialog("工艺乏值时间秒不能为空");
                return;
            }
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Alarm_Setting alarm_Setting = new Alarm_Setting();
            alarm_Setting.Id = Guid.NewGuid().ToString();
            alarm_Setting.WarningMessage = Message.Text;
            alarm_Setting.CreateTime = DateTime.Now;
            alarm_Setting.Processvalue = int.Parse(Processvalue.Text);
            alarm_Setting.IsDelete = 0;
            capProjectDb.Alarm_Setting.InsertOnSubmit(alarm_Setting);
            capProjectDb.SubmitChanges();
            uiButton6_Click(sender, e); //调用清空文本框方法
            ShowSuccessDialog("添加成功");
            GetList();


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
                string WarningMessage_Manager = row.Cells["WarningMessage_Manager"].Value.ToString();
                string Processvalue_Manager = row.Cells["Processvalue_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                Id = Id_Manager;
                Message.Text = WarningMessage_Manager;
                CreateTime.Text = CreateTime_Manager;
                Processvalue.Text = Processvalue_Manager;
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
            Message.Text = null;
            Processvalue.Text = null;
            CreateTime.Text = null;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Message.Text))
            {
                ShowWarningDialog("告警信息不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(Processvalue.Text))
            {
                ShowWarningDialog("工艺乏值时间秒不能为空");
                return;
            }

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Alarm_Setting alarm_Setting = capProjectDb.Alarm_Setting.Where(t => t.Id == Id).FirstOrDefault();
            alarm_Setting.WarningMessage = Message.Text;
            alarm_Setting.Processvalue = int.Parse(Processvalue.Text);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();


        }
    }
}
