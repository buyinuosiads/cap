using Cap.SystemSetup.Menu;
using Model;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.SystemSetup.Role
{
    public partial class Role : UIPage
    {

        List<Sys_Role> dataList = new List<Sys_Role>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string sort = string.Empty;

        public Role()
        {
            InitializeComponent();
            #region 列表列名
            dataTable.Columns.Add("RoleId");
            dataTable.Columns.Add("RoleName");
            dataTable.Columns.Add("MenuName");
            dataTable.Columns.Add("Sort");
            dataTable.Columns.Add("CreateTime");
            #endregion

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            List<Sys_Menu> sys_MenusList = capProjectDb.Sys_Menu.OrderBy(t => t.Sort).ToList();
            foreach (var item in sys_MenusList)
            {
                TreeNode treeNode = new TreeNode();
                treeNode.Text = item.MenuText;
                FPCD.Nodes.Add(treeNode);
            }
            SearchList();
        }

        public void SearchList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            dataList.Clear();
            dataList = capProjectDb.Sys_Role.OrderByDescending(t => t.CreateTime).ToList();
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
                dataTable.Rows.Add(dataList[i].RoleId, dataList[i].RoleName, dataList[i].MenuName, dataList[i].Sort, dataList[i].CreateTime);
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


            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            string sort_Manager = string.Empty;

            List<Sys_Menu> roleList = capProjectDb.Sys_Menu.OrderBy(a => a.Sort).ToList(); //全查询
            string Menu = string.Empty;
            foreach (TreeNode item in FPCD.Nodes)
            {
                if (item.Checked == true)
                {
                    Menu += item.ToString().Replace("TreeNode: ", null) + ";";
                }
            }


            string[] MenuList = Menu.Split(";");
            for (int i = 0; i < MenuList.Length; i++)
            {
                string name = MenuList[i].ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    Sys_Menu role = roleList.Where(t => t.MenuText.Equals(name)).FirstOrDefault();
                    sort_Manager += role.Sort + ";";
                }
            }

            Sys_Role sys_Role = new Sys_Role();
            sys_Role.RoleName = RoleName_Manager.Text;
            sys_Role.MenuName = Menu;
            sys_Role.Sort = sort_Manager;
            sys_Role.CreateTime = DateTime.Now;
            capProjectDb.Sys_Role.InsertOnSubmit(sys_Role);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("添加成功");
            SearchList();


        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {


                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string RoleId = row.Cells["RoleId"].Value.ToString();
                string RoleName = row.Cells["RoleName"].Value.ToString();
                string CreateTime = row.Cells["CreateTime"].Value.ToString();
                string MenuName = row.Cells["MenuName"].Value.ToString();
                string Sort = row.Cells["Sort"].Value.ToString();

                Id = RoleId;
                sort = Sort;
                RoleName_Manager.Text = RoleName;
                FPCD.Text = MenuName;

                if (!string.IsNullOrEmpty(MenuName))
                {
                    string[] role = MenuName.Split(';');
                    foreach (TreeNode item in FPCD.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString())
                            {
                                item.Checked = true;
                                break;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                else
                {
                    foreach (TreeNode item in FPCD.Nodes)
                    {
                        item.Checked = false;
                    }
                }
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            string sort_Manager = string.Empty;

            List<Sys_Menu> roleList = capProjectDb.Sys_Menu.OrderBy(a => a.Sort).ToList(); //全查询
            string Menu = string.Empty;
            foreach (TreeNode item in FPCD.Nodes)
            {
                if (item.Checked == true)
                {
                    Menu += item.ToString().Replace("TreeNode: ", null) + ";";
                }
            }


            string[] MenuList = Menu.Split(";");
            for (int i = 0; i < MenuList.Length; i++)
            {
                string name = MenuList[i].ToString();
                if (!string.IsNullOrEmpty(name))
                {
                    Sys_Menu role = roleList.Where(t => t.MenuText.Equals(name)).FirstOrDefault();
                    sort_Manager += role.Sort + ";";
                }
            }


            Sys_Role sys_Role = capProjectDb.Sys_Role.Where(t => t.RoleId == int.Parse(Id)).FirstOrDefault();
            sys_Role.RoleName = RoleName_Manager.Text;
            sys_Role.MenuName = Menu;
            sys_Role.Sort = sort_Manager;
            capProjectDb.SubmitChanges();

            ShowSuccessDialog("修改成功");
            SearchList();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
