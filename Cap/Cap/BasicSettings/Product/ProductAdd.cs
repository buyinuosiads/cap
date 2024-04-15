using Sunny.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cap.BasicSettings.Product
{
    public partial class ProductAdd : UIEditForm
    {
        public ProductAdd()
        {
            InitializeComponent();


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

        private void ProductAdd_Load(object sender, EventArgs e)
        {


        }
    }
}
