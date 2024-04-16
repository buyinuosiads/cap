using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Cap.SystemSetup.Menu
{
    public partial class MenuBar : UIPage
    {
        List<Data> dataList = new List<Data>();
        //List<Sys_Menu> dataList = new List<Sys_Menu>();
        DataTable dataTable = new DataTable("DataTable");

        public MenuBar()
        {
            InitializeComponent();

            #region 列表列名
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
            dataTable.Columns.Add("MenuText");
            dataTable.Columns.Add("CreateTime");
            SearchList();//执行查询
            #endregion


            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.MenuText = "菜单" + i;
                data.CreateTime = DateTime.Now.ToString();
                dataList.Add(data);
            }

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
                dataTable.Rows.Add(dataList[i].MenuText, dataList[i].CreateTime);
            }

        }


        public class Data
        {
            public string MenuText { get; set; }

            public string CreateTime { get; set; }
        }


        public void SearchList()
        {
            //CapProjectDataContext capProjectDb = new CapProjectDataContext();

            //dataList = capProjectDb.Sys_Menu.OrderByDescending(t => t.CreateTime).ToList();

            //uiDataGridView1.DataSource = dataTable;
            ////不自动生成列
            //uiDataGridView1.AutoGenerateColumns = false;

            ////设置分页控件总数
            //uiPagination1.TotalCount = dataList.Count;

            ////设置分页控件每页数量
            //uiPagination1.PageSize = 15;


            //dataTable.Rows.Clear();
            //for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            //{
            //    if (i >= dataList.Count) break;
            //    dataTable.Rows.Add(dataList[i].MenuText, dataList[i].CreateTime);
            //}


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

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string rowData = row.Cells["MenuText"].Value.ToString();
            //string Column2 = row.Cells["Column2"].Value.ToString();
            //string Column3 = row.Cells["Column3"].Value.ToString();
            //string Column4 = row.Cells["Column4"].Value.ToString();


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

        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            //dataTable.Rows.Clear();
            //for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            //{
            //    if (i >= dataList.Count) break;
            //    dataTable.Rows.Add(dataList[i].MenuText, dataList[i].CreateTime);
            //}
        }


        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            //MenuBarAdd menu = new MenuBarAdd();
            //menu.Render();
            //menu.ShowDialog();
            //if (menu.IsOK)
            //{
            //    //ShowSuccessDialog();
            //    SearchList();
            //}
            //menu.Dispose();
            //SearchList();


            dataTable.Rows.Add(edtName.Text, DateTime.Now);


        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string rowData = row.Cells["MenuText"].Value.ToString();
                edtName.Text = rowData;
            }
        }
    }
}
