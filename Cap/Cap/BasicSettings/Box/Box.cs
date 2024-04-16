using Cap.AttendanceManagementParent.AttendanceManagement;
using Cap.BasicSettings.Product;
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

namespace Cap.BasicSettings.Box
{
    public partial class Box : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public Box()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Column1 = "箱规名称" + i;
                data.Column2 = i.Mod(2) == 0 ? "100" : "200";
                data.Column3 = "耗材" + i;
                data.Column4 = DateTime.Now.ToString();
                data.Column5 = "管理员";
                data.Column6 = "辅料" + i;
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
            dataTable.Columns.Add("Column3");
            dataTable.Columns.Add("Column6");
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







            uiComboDataGridView2.DataGridView.Init();
            uiComboDataGridView2.DataGridView.MultiSelect = true;//设置可多选
            uiComboDataGridView2.DataGridView.ReadOnly = false;
            uiComboDataGridView2.ShowFilter = true;
            // 添加多选按钮列
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "多选";
            checkBoxColumn.Name = "checkBoxColumn";
            uiComboDataGridView2.DataGridView.Columns.Insert(0, checkBoxColumn);


            // 添加其他列
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "辅料";
            column1.Name = "辅料";
            uiComboDataGridView2.DataGridView.Columns.Add(column1);


            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.HeaderText = "辅料数量";
            editableColumn.Name = "EditableColumn";
            uiComboDataGridView2.DataGridView.Columns.Add(editableColumn);
            for (int i = 1; i <= 20; i++)
            {
                uiComboDataGridView2.DataGridView.Rows.Add(false, "辅料" + i);
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
            //未连接数据库，通过模拟数据来实现
            //一般通过ORM的分页去取数据来填充
            //pageIndex：第几页，和界面对应，从1开始，取数据可能要用pageIndex - 1
            //count：单页数据量，也就是PageSize值

            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2, dataList[i].Column3, dataList[i].Column6, dataList[i].Column4, dataList[i].Column5);
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
            string Column1 = row.Cells["BoxName"].Value.ToString();
            string Column2 = row.Cells["Column6"].Value.ToString();
            string Column3 = row.Cells["ConsumablesCount"].Value.ToString();

            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                BoxEdit frm = new BoxEdit(Column1, Column2, Column3);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }

            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                BoxEdit frm = new BoxEdit(Column1, Column2, Column3);
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
            public string Column6 { get; set; }
            public override string ToString()
            {
                return Column1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //BoxAdd frm = new BoxAdd();
            //frm.Render();
            //frm.ShowDialog();
            //frm.Dispose();
            dataTable.Rows.Add(uiTextBox1.Text, uiTextBox2.Text, uiComboTreeView2.Text, uiComboDataGridView2.Text, DateTime.Now, uiTextBox4.Text);
        }

        private void Box_Initialize(object sender, EventArgs e)
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
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Column1 = row.Cells["BoxName"].Value.ToString();
                string Column2 = row.Cells["Column6"].Value.ToString();
                string Column3 = row.Cells["ConsumablesCount"].Value.ToString();
                string FullBoxCount = row.Cells["FullBoxCount"].Value.ToString();
                string uiTextBox = row.Cells["CreationTime"].Value.ToString();
                string CreationName = row.Cells["CreationName"].Value.ToString();


                uiTextBox1.Text = Column1;
                uiComboTreeView2.Text = Column3;
                uiComboDataGridView2.Text = Column2;
                uiTextBox2.Text = FullBoxCount;
                uiTextBox3.Text = uiTextBox;
                uiTextBox4.Text = CreationName;


                if (!string.IsNullOrEmpty(Column3))
                {
                    string[] role = Column3.Split(';');
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
                uiComboTreeView2.Text = Column3;
                uiComboDataGridView2.DataGridView.Rows.Clear();
                uiComboDataGridView2.DataGridView.DataSource = null;

                for (int i = 1; i <= 20; i++)
                {
                    if (Column2 == "辅料" + i)
                    {
                        uiComboDataGridView2.DataGridView.Rows.Add(true, "辅料" + i);
                    }
                    else
                    {
                        uiComboDataGridView2.DataGridView.Rows.Add(false, "辅料" + i);
                    }
                }

            }

        }

        private void uiComboDataGridView2_ValueChanged(object sender, object value)
        {
            string txt = string.Empty;
            // 遍历 DataGridView 中的所有行
            foreach (DataGridViewRow row in uiComboDataGridView2.DataGridView.Rows)
            {
                string check = string.Empty;//是否选中
                string gongyimingcheng = string.Empty; //辅料名称 
                int shuliang = 0;  //辅料数量
                int num = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (num == 0)
                        {
                            check = cell.Value.ToString();
                        }
                        else if (num == 1)
                        {
                            gongyimingcheng = cell.Value.ToString();
                        }
                        else
                        {
                            shuliang += int.Parse(cell.Value.ToString());
                        }
                    }
                    num++;
                }
                if (check == "True")
                {
                    txt += gongyimingcheng + ";";
                }
            }
            uiComboDataGridView2.Text = txt;
        }
    }
}
