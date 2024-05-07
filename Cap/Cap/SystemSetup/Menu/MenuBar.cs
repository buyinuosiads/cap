using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cap.SystemSetup.Menu
{
    public partial class MenuBar : UIPage
    {
        List<Sys_Menu> dataList = new List<Sys_Menu>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public MenuBar()
        {
            InitializeComponent();

            #region 列表列名
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
            dataTable.Columns.Add("Menu_Id");
            dataTable.Columns.Add("MenuText");
            dataTable.Columns.Add("Icon_Manager");
            dataTable.Columns.Add("CreateTime");
            GetList();//执行查询
            #endregion


        }

        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();

            dataList = capProjectDb.Sys_Menu.OrderByDescending(t => t.CreateTime).OrderBy(t => t.Sort).ToList();

            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;

            //设置分页控件总数
            uiPagination1.TotalCount = dataList.Count;

            //设置分页控件每页数量
            uiPagination1.PageSize = 15;


            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].MenuText, dataList[i].Icon, dataList[i].CreateTime);
            }
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }


        private void MenuBar_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string rowData = row.Cells["MenuText"].Value.ToString();

                // 确保点击的是按钮列
                if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                {
                    MenuBarDetail menuBarDetail = new MenuBarDetail(rowData);///实例化窗体
                    menuBarDetail.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                    menuBarDetail.ShowDialog();///显示窗体 
                }


                if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                {
                    MenuBarEdit menuBarEdit = new MenuBarEdit(rowData);///实例化窗体
                    menuBarEdit.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                    menuBarEdit.ShowDialog();///显示窗体 
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
        }

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].MenuText, dataList[i].Icon, dataList[i].CreateTime);
            }
        }



        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据


                string Menu_Id = row.Cells["Menu_Id"].Value.ToString();
                string MenuText = row.Cells["MenuText"].Value.ToString();
                string Icon_Manager = row.Cells["Icon_Manager"].Value.ToString();
                Id = Menu_Id;
                Menu_Name.Text = MenuText;
                Menu_Icon.Text = Icon_Manager;
                uiSymbolLabel1.Symbol = int.Parse(Icon_Manager);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }



        private void uiTextBox1_Click(object sender, EventArgs e)
        {
            FSymbols fSymbols = new FSymbols();
            fSymbols.ShowDialog();

            Menu_Icon.Text = fSymbols.GetTextBoxValue();
            uiSymbolLabel1.Symbol = int.Parse(fSymbols.GetTextBoxValue());
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Sys_Menu sys_Menu = capProjectDb.Sys_Menu.Where(t => t.Id == Id).FirstOrDefault();
            sys_Menu.MenuText = Menu_Name.Text;
            sys_Menu.Icon = Menu_Icon.Text;
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();


        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Menu_Name.Text = null;
            Menu_Icon.Text = null;
            uiSymbolLabel1.Symbol = 0;

        }
    }
}
