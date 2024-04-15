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

namespace Cap.BasicSettings.Box
{
    public partial class BoxEdit : UIEditForm
    {
        public BoxEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiComboTreeView2.Text = Column3;
            uiComboDataGridView2.Text = Column2;




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
                    }
                }
            }
            uiComboTreeView2.Text = Column3;




            //DataTable dt = new DataTable(); 
            //dt.Columns.Add("Column1", typeof(string));
            //for (int i = 0; i < 100; i++)
            //{
            //    dt.Rows.Add("辅料" + i);
            //}
            //uiComboDataGridView2.DataGridView.Init();
            //uiComboDataGridView2.DataGridView.MultiSelect = true;//设置可多选
            //uiComboDataGridView2.ItemSize = new System.Drawing.Size(360, 240);
            //uiComboDataGridView2.DataGridView.AddColumn("辅料", "Column1");
            //uiComboDataGridView2.DataGridView.ReadOnly = false;
            //uiComboDataGridView2.ShowFilter = true;
            //uiComboDataGridView2.DataGridView.DataSource = dt;
            //uiComboDataGridView2.FilterColumnName = "Column1"; //不设置则全部列过滤
            //// 在 DataGridView 中添加一个复选框列用于多选功能
            //DataGridViewCheckBoxColumn multiSelectColumn = new DataGridViewCheckBoxColumn();
            //multiSelectColumn.HeaderText = "选择";
            //multiSelectColumn.Name = "MultiSelectColumn";
            //uiComboDataGridView2.DataGridView.Columns.Insert(0, multiSelectColumn);
            //// 在 DataGridView 中添加一个可编辑的列
            //DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            //editableColumn.HeaderText = "辅料数量";
            //editableColumn.Name = "EditableColumn";
            //uiComboDataGridView2.DataGridView.Columns.Add(editableColumn);



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
