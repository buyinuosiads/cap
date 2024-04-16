﻿using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.Accessories;
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

namespace Cap.BasicSettings.Technology
{
    public partial class Technology : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public Technology()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Column1 = "工艺名称" + i;
                data.zhuliao = "主料" + i;
                data.fuliao = "辅料" + i;
                data.Column3 = DateTime.Now.ToString();
                data.Column4 = "管理员";
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("zhuliao");
            dataTable.Columns.Add("fuliao");
            dataTable.Columns.Add("Column3");
            dataTable.Columns.Add("Column4");
            uiDataGridView1.DataSource = dataTable;

            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;

            //设置分页控件总数
            uiPagination1.TotalCount = dataList.Count;

            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
        }
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].zhuliao, dataList[i].fuliao, dataList[i].Column3, dataList[i].Column4);
            }
        }


        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Column1 = row.Cells["TechnologyName"].Value.ToString();
            string zhuliao = row.Cells["zhuliao"].Value.ToString();
            string fuliao = row.Cells["fuliao"].Value.ToString();

            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                TechnologyEdit frm = new TechnologyEdit(Column1, zhuliao, fuliao);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                TechnologyEdit frm = new TechnologyEdit(Column1, zhuliao, fuliao);
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
            public string fuliao { get; set; }
            public string zhuliao { get; set; }
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }

            public string Column4 { get; set; }

            public override string ToString()
            {
                return Column1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //TechnologyAdd frm = new TechnologyAdd();
            //frm.Render();
            //frm.ShowDialog();
            dataTable.Rows.Add(edtName.Text, uiComboTreeView1.Text, uiComboTreeView3.Text, uiTextBox1.Text, uiTextBox2.Text);
        }

        private void Technology_Initialize(object sender, EventArgs e)
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
                string Column1 = row.Cells["TechnologyName"].Value.ToString();
                string zhuliao = row.Cells["zhuliao"].Value.ToString();
                string fuliao = row.Cells["fuliao"].Value.ToString();
                string CreationTime = row.Cells["CreationTime"].Value.ToString();
                string CreationName = row.Cells["CreationName"].Value.ToString();

                uiTextBox1.Text = CreationTime;
                uiTextBox2.Text = CreationName;


                edtName.Text = Column1;


                if (!string.IsNullOrEmpty(zhuliao))
                {
                    string[] role = zhuliao.Split(';');
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
                uiComboTreeView1.Text = zhuliao;



                if (!string.IsNullOrEmpty(fuliao))
                {
                    string[] role = fuliao.Split(';');
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
                uiComboTreeView3.Text = fuliao;
            }
        }
    }
}
