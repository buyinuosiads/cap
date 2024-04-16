using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.ToolSettings;
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

namespace Cap.BasicSettings.Product
{
    public partial class Product : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public Product()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Column1 = "产品名称" + i;
                data.Column2 = "工艺名称" + i;
                data.Column3 = i.Mod(2) == 0 ? "100" : "200";
                data.Column4 = DateTime.Now.ToString();
                data.Column5 = "管理员";
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
            dataTable.Columns.Add("Column3");
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






            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(string));
            dt.Columns.Add("Column2", typeof(string));
            for (int i = 0; i < 100; i++)
            {
                dt.Rows.Add("工艺名称" + i, 100 + i);
            }
            uiComboDataGridView2.DataGridView.Init();
            uiComboDataGridView2.DataGridView.MultiSelect = true;//设置可多选
            uiComboDataGridView2.ItemSize = new System.Drawing.Size(360, 240);
            uiComboDataGridView2.DataGridView.AddColumn("工艺名称", "Column1");
            uiComboDataGridView2.DataGridView.AddColumn("工艺价格", "Column2");
            uiComboDataGridView2.DataGridView.ReadOnly = false;
            uiComboDataGridView2.ShowFilter = true;
            uiComboDataGridView2.DataGridView.DataSource = dt;
            uiComboDataGridView2.FilterColumnName = "Column1"; //不设置则全部列过滤
            // 在 DataGridView 中添加一个复选框列用于多选功能
            DataGridViewCheckBoxColumn multiSelectColumn = new DataGridViewCheckBoxColumn();
            multiSelectColumn.HeaderText = "选择";
            multiSelectColumn.Name = "MultiSelectColumn";
            uiComboDataGridView2.DataGridView.Columns.Insert(0, multiSelectColumn);






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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2, dataList[i].Column3, dataList[i].Column4, dataList[i].Column5);
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
            string Column1 = row.Cells["ProductName"].Value.ToString();
            string Column2 = row.Cells["TechnologyName"].Value.ToString();
            string Column3 = row.Cells["Price"].Value.ToString();

            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                ProductEdit frm = new ProductEdit(Column1, Column2, Column3);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }

            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                ProductEdit frm = new ProductEdit(Column1, Column2, Column3);
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

            public override string ToString()
            {
                return Column1;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //ProductAdd frm = new ProductAdd();
            //frm.Render();
            //frm.ShowDialog();
            //frm.Dispose();
            dataTable.Rows.Add(edtName.Text, uiComboDataGridView2.Text, uiTextBox1.Text, DateTime.Now, uiTextBox3.Text);
        }

        private void uiPagination1_Click(object sender, EventArgs e)
        {

        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Product_Initialize(object sender, EventArgs e)
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
                string Column1 = row.Cells["ProductName"].Value.ToString();
                string Column2 = row.Cells["TechnologyName"].Value.ToString();
                string Column3 = row.Cells["Price"].Value.ToString();
                string CreationTime = row.Cells["CreationTime"].Value.ToString();
                string CreationName = row.Cells["CreationName"].Value.ToString();



                uiComboDataGridView2.DataGridView.DataSource = null;
                uiComboDataGridView2.DataGridView.Rows.Clear();
                uiComboDataGridView2.DataGridView.Init();
                uiComboDataGridView2.DataGridView.MultiSelect = true;//设置可多选
                uiComboDataGridView2.ItemSize = new System.Drawing.Size(360, 240);
                uiComboDataGridView2.DataGridView.ReadOnly = false;
                uiComboDataGridView2.ShowFilter = true;
                uiComboDataGridView2.FilterColumnName = "Column1"; //不设置则全部列过滤
                for (int i = 1; i <= 20; i++)
                {
                    if (Column2 == "工艺名称" + i)
                    {
                        uiComboDataGridView2.DataGridView.Rows.Add(true, "工艺名称" + i, 100 + i);
                    }
                    else
                    {
                        uiComboDataGridView2.DataGridView.Rows.Add(false, "工艺名称" + i, 100 + i);
                    }
                }




                edtName.Text = Column1;
                uiComboDataGridView2.Text = Column2;
                uiTextBox1.Text = Column3;
                uiTextBox2.Text = CreationTime;
                uiTextBox3.Text = CreationName;









            }
        }

        private void uiComboDataGridView2_ValueChanged(object sender, object value)
        {
            int Money = 0; //价格
            string txt = string.Empty;
            // 遍历 DataGridView 中的所有行
            foreach (DataGridViewRow row in uiComboDataGridView2.DataGridView.Rows)
            {
                string check = string.Empty;//是否选中
                string gongyimingcheng = string.Empty; //工艺名称 
                int jiage = 0;
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
                            jiage += int.Parse(cell.Value.ToString());
                        }
                    }
                    num++;
                }
                if (check == "True")
                {
                    txt += gongyimingcheng + ";";
                    Money += jiage;
                }
            }
            uiComboDataGridView2.Text = txt;
            uiTextBox1.Text = Money.ToString();
        }
    }
}
