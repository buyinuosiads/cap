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
    public partial class BoxAdd : UIEditForm
    {
        public BoxAdd()
        {
            InitializeComponent();


            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(string));

            for (int i = 0; i < 100; i++)
            {
                dt.Rows.Add("辅料" + i);
            }
            uiComboDataGridView2.DataGridView.Init();
            uiComboDataGridView2.DataGridView.MultiSelect = true;//设置可多选
            uiComboDataGridView2.ItemSize = new System.Drawing.Size(360, 240);
            uiComboDataGridView2.DataGridView.AddColumn("辅料", "Column1"); 
            uiComboDataGridView2.DataGridView.ReadOnly = false;
            uiComboDataGridView2.ShowFilter = true;
            uiComboDataGridView2.DataGridView.DataSource = dt;
            uiComboDataGridView2.FilterColumnName = "Column1"; //不设置则全部列过滤


            // 在 DataGridView 中添加一个复选框列用于多选功能
            DataGridViewCheckBoxColumn multiSelectColumn = new DataGridViewCheckBoxColumn();
            multiSelectColumn.HeaderText = "选择";
            multiSelectColumn.Name = "MultiSelectColumn";
            uiComboDataGridView2.DataGridView.Columns.Insert(0, multiSelectColumn);


            // 在 DataGridView 中添加一个可编辑的列
            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.HeaderText = "辅料数量";
            editableColumn.Name = "EditableColumn";
            uiComboDataGridView2.DataGridView.Columns.Add(editableColumn);

        }





        private void uiComboDataGridView2_ValueChanged(object sender, object value)
        {
            string txt = string.Empty;
            // 遍历 DataGridView 中的所有行
            foreach (DataGridViewRow row in uiComboDataGridView2.DataGridView.Rows)
            {
                string check = string.Empty;//是否选中
                string fuliao = string.Empty; //辅料
                string number = string.Empty; //数量
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
                            fuliao = cell.Value.ToString();
                        }
                        else
                        {
                            number = cell.Value.ToString();
                        }
                    }
                    num++;
                }
                if (check == "True")
                {
                    txt += fuliao + ";";
                }
            }
            uiComboDataGridView2.Text = txt;
        }
    }
}
