using Cap.BasicSettings.WidthOfCloth;
using Cap.SystemSetup;
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

namespace Cap.BasicSettings.Perm
{
    public partial class Perm : UIPage
    {
        List<PermSetting> dataList = new List<PermSetting>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public Perm(string name)
        {
            InitializeComponent();
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("PermName_Manager");
            dataTable.Columns.Add("PermSpecifications_Manager");
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
            Expression<Func<PermSetting, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(PermName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.PermName.Contains(PermName.Text));
            };
            if (!string.IsNullOrEmpty(PermSpecifications.Text))
            {
                where = ExpressionBuilder.And(where, f => f.PermSpecifications.Contains(PermSpecifications.Text));
            };

            dataList.Clear();
            List<PermSetting> sys_Users = capProjectDb.PermSetting.Where(where).OrderBy(a => a.Id).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].PermName, dataList[i].PermSpecifications, dataList[i].CreateTime, dataList[i].CreateName);
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
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].PermName, dataList[i].PermSpecifications, dataList[i].CreateTime, dataList[i].CreateName);
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
                PermSetting permSetting = new PermSetting();
                permSetting.Id = Guid.NewGuid().ToString();
                permSetting.PermName = PermName.Text;
                permSetting.PermSpecifications = PermSpecifications.Text;
                permSetting.CreateTime = DateTime.Now;
                permSetting.CreateName = _Name;
                permSetting.IsDelete = 0;
                //保存数据
                capProjectDb.PermSetting.InsertOnSubmit(permSetting);
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
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据            
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
            string PermName_Manager = row.Cells["PermName_Manager"].Value.ToString();
            string PermSpecifications_Manager = row.Cells["PermSpecifications_Manager"].Value.ToString();

            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                PermEdit frm = new PermEdit(PermName_Manager, PermSpecifications_Manager);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();

            }


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                PermEdit frm = new PermEdit(PermName_Manager, PermSpecifications_Manager);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    PermSetting sys_User = capProjectDb.PermSetting.Where(t => t.Id == Id_Manager).FirstOrDefault();
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

        private void Perm_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
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
                string PermName_Manager = row.Cells["PermName_Manager"].Value.ToString();
                string PermSpecifications_Manager = row.Cells["PermSpecifications_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                PermName.Text = PermName_Manager;
                PermSpecifications.Text = PermSpecifications_Manager;
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
            PermName.Text = null;
            PermSpecifications.Text = null;
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
            //查询数据
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
                PermSetting permSetting = capProjectDb.PermSetting.Where(t => t.Id == Id).FirstOrDefault();
                permSetting.PermName = PermName.Text;
                permSetting.PermSpecifications = PermSpecifications.Text;
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