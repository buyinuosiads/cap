using Cap.SystemSetup.Role;
using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cap.SystemSetup.Company;

namespace Cap.SystemSetup
{
    public partial class User : UIPage
    {
        List<Data> dataList = new List<Data>();
        //List<Sys_User> dataList = new List<Sys_User>();
        DataTable dataTable = new DataTable("DataTable");
        public UserEdit userEdit = null;

        public User()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Account");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Sex");
            dataTable.Columns.Add("Position");

            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.Name = "姓名" + i;
                data.Account = "账号" + i;
                data.Phone = "电话" + i;
                data.Address = i.ToString();
                data.Position = "员工" + i.ToString();
                data.Sex = i.Mod(2) == 0 ? 0 : 1;
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
                string sex = string.Empty;
                if (dataList[i].Sex == 0) { sex = "男"; } else { sex = "女"; }
                dataTable.Rows.Add(dataList[i].Name, dataList[i].Account, dataList[i].Phone, dataList[i].Address, sex, dataList[i].Position);
            }

            GetList();
        }


        public class Data
        {
            public string Name { get; set; }

            public string Account { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public string Position { get; set; }
            public int Sex { get; set; }

        }


        public void GetList()
        {
            //CapProjectDataContext capProjectDb = new CapProjectDataContext();
            //dataList.Clear();
            //List<Sys_User> sys_Users = capProjectDb.Sys_User.ToList();
            //foreach (var item in sys_Users)
            //{
            //    dataList.Add(item);
            //}

            //uiDataGridView1.DataSource = dataTable;
            ////不自动生成列
            //uiDataGridView1.AutoGenerateColumns = false;
            ////设置分页控件总数
            //uiPagination1.TotalCount = sys_Users.Count;
            ////设置分页控件每页数量
            //uiPagination1.PageSize = 15;
            //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            //dataTable.Rows.Clear();
            //for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            //{
            //    if (i >= dataList.Count) break;
            //    string sex = string.Empty;
            //    if (dataList[i].Sex == 0) { sex = "男"; } else { sex = "女"; }
            //    dataTable.Rows.Add(dataList[i].Name, dataList[i].Account, dataList[i].Phone, dataList[i].Address, sex, dataList[i].Position);
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


            //dataTable.Rows.Clear();
            //for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            //{

            //    if (i >= dataList.Count) break;
            //    string sex = string.Empty;
            //    if (dataList[i].Sex == 0) { sex = "男"; } else { sex = "女"; }
            //    dataTable.Rows.Add(dataList[i].Name, dataList[i].Account, dataList[i].Phone, dataList[i].Address, sex, dataList[i].Position);
            //}


        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }






        private void Company_Initialize(object sender, EventArgs e)
        {



            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompanyAdd frm = new CompanyAdd();
            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
                ShowSuccessDialog(frm.Person.ToString());
            }

            frm.Dispose();
        }

        private void uiDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string rowData = row.Cells["Column1"].Value.ToString(); // 替换YourColumnName为你需要的列名
                string Column2 = row.Cells["Column2"].Value.ToString(); // 替换YourColumnName为你需要的列名
                string Column3 = row.Cells["Column3"].Value.ToString(); // 替换YourColumnName为你需要的列名
                UserDetail userDetail = new UserDetail();
                userDetail.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                userDetail.ShowDialog();///显示窗体 

            }



            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {

                UserEdit user = new UserEdit();///实例化窗体
                user.ShowDialog();

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


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.Render();
            userAdd.ShowDialog();
            if (userAdd.IsOK)
            {
                GetList();
            }
            userAdd.Dispose();
        }
    }
}
