using Cap.SystemSetup.Menu;
using Model;
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

namespace Cap.SystemSetup.Role
{
    public partial class Role : UIPage
    {
        List<Data> dataList = new List<Data>();
        //List<Sys_Role> dataList = new List<Sys_Role>();
        DataTable dataTable = new DataTable("DataTable");


        public Role()
        {
            InitializeComponent();



            #region 列表列名
            dataTable.Columns.Add("RoleId");
            dataTable.Columns.Add("RoleName");
            dataTable.Columns.Add("CreateTime");
            #endregion


            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.RoleId = "菜单" + i;
                data.RoleName = "角色" + i;
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
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].RoleId, dataList[i].RoleName, dataList[i].CreateTime);
            }



            SearchList();
        }

        public void SearchList()
        {
            //CapProjectDataContext capProjectDb = new CapProjectDataContext();
            //dataList.Clear();
            //dataList = capProjectDb.Sys_Role.OrderByDescending(t => t.CreateTime).ToList();
            //uiDataGridView1.DataSource = dataTable;

            ////不自动生成列
            //uiDataGridView1.AutoGenerateColumns = false;

            ////设置分页控件总数
            //uiPagination1.TotalCount = dataList.Count;

            ////设置分页控件每页数量
            //uiPagination1.PageSize = 15;
            //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            //dataTable.Rows.Clear();
            //for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            //{
            //    if (i >= dataList.Count) break;
            //    dataTable.Rows.Add(dataList[i].RoleId, dataList[i].RoleName, dataList[i].CreateTime);
            //}
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

            //dataTable.Rows.Clear();
            //for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            //{
            //    if (i >= dataList.Count) break;
            //    dataTable.Rows.Add(dataList[i].RoleId, dataList[i].RoleName, dataList[i].CreateTime);
            //}
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }


        public class Data
        {
            public string RoleId { get; set; }

            public string CreateTime { get; set; }
            public string RoleName { get; set; }
        }
        private void Role_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
        }



        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string RoleId = row.Cells["RoleId"].Value.ToString();
            string RoleName = row.Cells["RoleName"].Value.ToString();
            string CreateTime = row.Cells["CreateTime"].Value.ToString();


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                RoleDetial roleDetial = new RoleDetial(RoleName);///实例化窗体
                roleDetial.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                roleDetial.ShowDialog();///显示窗体 
            }


            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                RoleEdit roleEdit = new RoleEdit(RoleId, RoleName);///实例化窗体
                roleEdit.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置

                roleEdit.Render();
                roleEdit.ShowDialog();
                if (roleEdit.IsOK)
                {

                }
                roleEdit.Dispose();
                SearchList();

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

     

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            RoleAdd roleAdd = new RoleAdd();
            roleAdd.Render();
            roleAdd.ShowDialog();
            if (roleAdd.IsOK)
            {
                SearchList();
            }
            roleAdd.Dispose();
        }
    }
}
