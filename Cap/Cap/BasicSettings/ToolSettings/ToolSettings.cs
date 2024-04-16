using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.WidthOfCloth;
using Cap.SystemSetup;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.BasicSettings.ToolSettings
{
    public partial class ToolSettings : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public ToolSettings()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Column1 = "刀具名称" + i;
                data.Column2 = i.Mod(2) == 0 ? "10" : "20";
                data.Column3 = i.Mod(2) == 0 ? "0.1%" : "0.2%";
                data.Column4 = DateTime.Now.ToString();
                data.Column5 = "管理员";
                data.fukuan = "幅宽" + i;
                data.xishu = "系数" + i;
                data.tangtou = "烫头" + i;
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
            dataTable.Columns.Add("Column3");
            dataTable.Columns.Add("fukuan");
            dataTable.Columns.Add("xishu");
            dataTable.Columns.Add("tangtou");
            dataTable.Columns.Add("Column4");
            dataTable.Columns.Add("Column5");


            uiDataGridView1.DataSource = dataTable;

            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;

            //设置分页控件总数
            uiPagination1.TotalCount = dataList.Count;

            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2, dataList[i].Column3,
                    dataList[i].fukuan,
                    dataList[i].xishu,
                    dataList[i].tangtou,
                    dataList[i].Column4,
                    dataList[i].Column5);
            }


        }
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ToolSettingsAdd frm = new ToolSettingsAdd();
            //frm.Render();
            //frm.ShowDialog();
            //frm.Dispose();
              dataTable.Rows.Add(edtName.Text,
              edtAge.Text,
              uiTextBox1.Text,
              uiComboTreeView2.Text,
              uiComboTreeView1.Text,
              uiComboTreeView3.Text,
              DateTime.Now,
              uiTextBox3.Text);
        }
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Column1 = row.Cells["ToolName"].Value.ToString();
            string Column2 = row.Cells["ToolQuota"].Value.ToString();
            string Column3 = row.Cells["FaultToleranceValue"].Value.ToString();
            string fukuan = row.Cells["fukuan"].Value.ToString();
            string xishu = row.Cells["xishu"].Value.ToString();
            string tangtou = row.Cells["tangtou"].Value.ToString();


            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                ToolSettingsEdit frm = new ToolSettingsEdit(Column1, Column2, Column3, fukuan, xishu, tangtou);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }

            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                ToolSettingsEdit frm = new ToolSettingsEdit(Column1, Column2, Column3, fukuan, xishu, tangtou);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }

            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    ShowSuccessTip("删除成功");
                    uiDataGridView1.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    ShowErrorTip("取消当前操作");
                }
            }



        }
        public class Data
        {
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }

            public string Column4 { get; set; }
            public string Column5 { get; set; }
            public string fukuan { get; set; }
            public string xishu { get; set; }
            public string tangtou { get; set; }




            public override string ToString()
            {
                return Column1;
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
                uiComboTreeView2.Text = null;
                uiComboTreeView1.Text = null;
                uiComboTreeView3.Text = null;


                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Column1 = row.Cells["ToolName"].Value.ToString();
                string Column2 = row.Cells["ToolQuota"].Value.ToString();
                string Column3 = row.Cells["FaultToleranceValue"].Value.ToString();
                string fukuan = row.Cells["fukuan"].Value.ToString();
                string xishu = row.Cells["xishu"].Value.ToString();
                string tangtou = row.Cells["tangtou"].Value.ToString();
                string CreationTime = row.Cells["CreationTime"].Value.ToString();
                string CreationName = row.Cells["CreationName"].Value.ToString();


                edtName.Text = Column1;
                edtAge.Text = Column2;
                uiTextBox1.Text = Column3;
                uiTextBox2.Text = CreationTime;
                uiTextBox3.Text = CreationName;


                if (!string.IsNullOrEmpty(fukuan))
                {
                    string[] role = fukuan.Split(';');
                    foreach (TreeNode item in uiComboTreeView2.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {

                            if (im == role[i].ToString())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                uiComboTreeView2.Text = fukuan;



                if (!string.IsNullOrEmpty(xishu))
                {
                    string[] role = xishu.Split(';');
                    foreach (TreeNode item in uiComboTreeView1.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {

                            if (im == role[i].ToString())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                uiComboTreeView1.Text = xishu;




                if (!string.IsNullOrEmpty(tangtou))
                {
                    string[] role = tangtou.Split(';');
                    foreach (TreeNode item in uiComboTreeView3.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {

                            if (im == role[i].ToString())
                            {
                                item.Checked = true;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                uiComboTreeView3.Text = tangtou;




            }
        }
    }
}
