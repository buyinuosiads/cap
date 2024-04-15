using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Cap.BasicSettings.Product
{
    public partial class ProductEdit : UIEditForm
    {
        public ProductEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiComboDataGridView2.Text = Column2 + ";";
            uiTextBox1.Text = Column3;


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
            column1.HeaderText = "工艺名称";
            column1.Name = "工艺名称";
            uiComboDataGridView2.DataGridView.Columns.Add(column1);


            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "工艺价格";
            column2.Name = "工艺价格";
            uiComboDataGridView2.DataGridView.Columns.Add(column2);


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



        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
