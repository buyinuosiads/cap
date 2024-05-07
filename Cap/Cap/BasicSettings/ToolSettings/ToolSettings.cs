using Cap.AlarmManagementParent.AlarmManagement;
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

namespace Cap.BasicSettings.ToolSettings
{
    public partial class ToolSettings : UIPage
    {
        List<ToolSetup> dataList = new List<ToolSetup>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public ToolSettings()
        {
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //Data data = new Data();
            //data.Column1 = "刀具名称" + i;
            //data.Column2 = i.Mod(2) == 0 ? "10" : "20";
            //data.Column3 = i.Mod(2) == 0 ? "0.1%" : "0.2%";
            //data.Column4 = DateTime.Now.ToString();
            //data.Column5 = "管理员";
            //data.fukuan = "幅宽" + i;
            //data.xishu = "系数" + i;
            //data.tangtou = "烫头" + i;
            //dataList.Add(data);
            //}

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("ToolName_Manager");
            dataTable.Columns.Add("WideRating_Manager");
            dataTable.Columns.Add("FaultTolerant_Manager");
            dataTable.Columns.Add("Breadth_Manager");
            dataTable.Columns.Add("Coefficient_Manager");
            dataTable.Columns.Add("PermName_Manager");
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
            Expression<Func<ToolSetup, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(ToolName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.ToolName.Contains(ToolName.Text));
            };

            dataList.Clear();
            List<ToolSetup> sys_Users = capProjectDb.ToolSetup.Where(where).OrderBy(a => a.Id).OrderByDescending(t => t.CreateTime).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id,
                    dataList[i].ToolName,
                    dataList[i].WideRating,
                    dataList[i].FaultTolerant,
                    dataList[i].Breadth,
                    dataList[i].Coefficient,
                    dataList[i].PermName,
                    dataList[i].CreateTime,
                    dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id,
                    dataList[i].ToolName,
                    dataList[i].WideRating,
                    dataList[i].FaultTolerant,
                    dataList[i].Breadth,
                    dataList[i].Coefficient,
                    dataList[i].PermName,
                    dataList[i].CreateTime,
                    dataList[i].CreateName);
            }
        }
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            ToolSetup toolSetup = new ToolSetup();
            toolSetup.Id = Guid.NewGuid().ToString();
            toolSetup.ToolName = ToolName.Text;
            toolSetup.WideRating = WideRating.Text;
            toolSetup.FaultTolerant = FaultTolerant.Text;
            toolSetup.Breadth = Breadth.Text;
            toolSetup.Coefficient = Coefficient.Text;
            toolSetup.PermName = PermName.Text;
            toolSetup.CreateTime = DateTime.Now;
            toolSetup.CreateName = CreateName.Text;
            toolSetup.IsDelete = 0;
            //保存数据
            capProjectDb.ToolSetup.InsertOnSubmit(toolSetup);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("添加成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();
        }
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {

                //// 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                //// 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();


                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    ToolSettingsEdit frm = new ToolSettingsEdit(Column1, Column2, Column3, fukuan, xishu, tangtou);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{

                //    ToolSettingsEdit frm = new ToolSettingsEdit(Column1, Column2, Column3, fukuan, xishu, tangtou);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {

                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        ToolSetup toolSetup = capProjectDb.ToolSetup.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        toolSetup.IsDelete = 99;
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

        private void ToolSettings_Initialize(object sender, EventArgs e)
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
                Breadth.Text = null;
                Coefficient.Text = null;
                PermName.Text = null;
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string ToolName_Manager = row.Cells["ToolName_Manager"].Value.ToString();
                string WideRating_Manager = row.Cells["WideRating_Manager"].Value.ToString();
                string FaultTolerant_Manager = row.Cells["FaultTolerant_Manager"].Value.ToString();
                string Breadth_Manager = row.Cells["Breadth_Manager"].Value.ToString();
                string Coefficient_Manager = row.Cells["Coefficient_Manager"].Value.ToString();
                string PermName_Manager = row.Cells["PermName_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                ToolName.Text = ToolName_Manager;
                WideRating.Text = WideRating_Manager;
                FaultTolerant.Text = FaultTolerant_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;

                if (!string.IsNullOrEmpty(Breadth_Manager))
                {
                    string[] role = Breadth_Manager.Split(';');
                    foreach (TreeNode item in Breadth.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString().Trim())
                            {
                                item.Checked = true;
                                break;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                Breadth.Text = Breadth_Manager;



                if (!string.IsNullOrEmpty(Coefficient_Manager))
                {
                    string[] role = Coefficient_Manager.Split(';');
                    foreach (TreeNode item in Coefficient.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString().Trim())
                            {
                                item.Checked = true;
                                break;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                Coefficient.Text = Coefficient_Manager;




                if (!string.IsNullOrEmpty(PermName_Manager))
                {
                    string[] role = PermName_Manager.Split(';');
                    foreach (TreeNode item in PermName.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString().Trim())
                            {
                                item.Checked = true;
                                break;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                PermName.Text = PermName_Manager;




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
        /// 清空文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            ToolName.Text = null;
            WideRating.Text = null;
            CreateTime.Text = null;
            FaultTolerant.Text = null;
            Breadth.Text = null;
            CreateName.Text = null;
            Coefficient.Text = null;
            PermName.Text = null;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            ToolSetup toolSetup = capProjectDb.ToolSetup.Where(t => t.Id == Id).FirstOrDefault();
            toolSetup.ToolName = ToolName.Text;
            toolSetup.WideRating = WideRating.Text;
            toolSetup.FaultTolerant = FaultTolerant.Text;
            toolSetup.Breadth = Breadth.Text;
            toolSetup.Coefficient = Coefficient.Text;
            toolSetup.PermName = PermName.Text;
            //保存数据
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();


        }
    }
}
