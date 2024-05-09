using Cap.SystemSetup.Role;
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
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cap.SystemSetup.Company;
using static Cap.SystemSetup.Menu.MenuBarAdd;

namespace Cap.SystemSetup
{
    public partial class User : UIPage
    {
        int? UserId = null;
        List<Sys_User> dataList = new List<Sys_User>();
        List<Sys_Role> sys_Roles = new List<Sys_Role>();

        DataTable dataTable = new DataTable("DataTable");
        public UserEdit userEdit = null;

        public User()
        {
            InitializeComponent();
            dataTable.Columns.Add("UserId_Manager");
            dataTable.Columns.Add("Name_Manager");
            dataTable.Columns.Add("Account_Manager");
            dataTable.Columns.Add("Phone_Manager");
            dataTable.Columns.Add("Address_Manager");
            dataTable.Columns.Add("Sex_Manager");
            dataTable.Columns.Add("Position_Manager");

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            sys_Roles = capProjectDb.Sys_Role.ToList();
            IList<string> infoList = new List<string>();
            foreach (var item in sys_Roles)
            {
                infoList.Add(item.RoleName);
            }
            Position.DataSource = infoList;
            Position.Text = null;
            GetList();
        }


        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<Sys_User, bool>> where = s => s.UserId != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(UserName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Name.Contains(UserName.Text));
            };
            if (!string.IsNullOrEmpty(Account.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Account.Contains(Account.Text));
            }
            if (!string.IsNullOrEmpty(Password.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Password.Contains(Password.Text));
            }
            if (!string.IsNullOrEmpty(Phone.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Phone.Contains(Phone.Text));
            }
            if (!string.IsNullOrEmpty(Position.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Position.Contains(Position.Text));

            }
            if (!string.IsNullOrEmpty(Address.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Address.Contains(Address.Text));
            }
            int Sex_Manager = 0;

            if (uiRadioButton1.Checked == true)
            {
                where = ExpressionBuilder.And(where, f => f.Sex == 0 || f.Sex == 1);
            }
            else
            {
                if (rbMale.Checked == true)
                {
                    Sex_Manager = 0;
                    where = ExpressionBuilder.And(where, f => f.Sex == Sex_Manager);
                }
                else
                {
                    Sex_Manager = 1;
                    where = ExpressionBuilder.And(where, f => f.Sex == Sex_Manager);
                }
            }

            dataList.Clear();
            List<Sys_User> sys_Users = capProjectDb.Sys_User.Where(where).OrderBy(a => a.UserId).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in sys_Users)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = sys_Users.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                string sex = string.Empty;
                if (dataList[i].Sex == 0) { sex = "男"; } else { sex = "女"; }
                dataTable.Rows.Add(dataList[i].UserId, dataList[i].Name, dataList[i].Account, dataList[i].Phone, dataList[i].Address, sex, dataList[i].Position);
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
            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                string sex = string.Empty;
                if (dataList[i].Sex == 0) { sex = "男"; } else { sex = "女"; }
                dataTable.Rows.Add(dataList[i].Name, dataList[i].Account, dataList[i].Phone, dataList[i].Address, sex, dataList[i].Position);
            }
        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }

        private void Company_Initialize(object sender, EventArgs e)
        {

            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompanyAdd frm = new CompanyAdd();
            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
            }

            frm.Dispose();
        }

        private void uiDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string UserId_Manager = row.Cells["UserId_Manager"].Value.ToString();
                string Name_Manager = row.Cells["Name_Manager"].Value.ToString();
                string Account_Manager = row.Cells["Account_Manager"].Value.ToString();
                string Phone_Manager = row.Cells["Phone_Manager"].Value.ToString();
                string Address_Manager = row.Cells["Address_Manager"].Value.ToString();
                string Sex_Manager = row.Cells["Sex_Manager"].Value.ToString();
                string Position_Manager = row.Cells["Position_Manager"].Value.ToString();

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Sys_User sys_User = capProjectDb.Sys_User.Where(t => t.UserId == int.Parse(UserId_Manager)).FirstOrDefault();
                        sys_User.IsDelete = 99;
                        capProjectDb.SubmitChanges();
                        ShowSuccessTip("删除成功");
                        uiButton6_Click(sender, e); //调用清空文本框方法
                        GetList();

                    }
                    else
                    {
                        ShowErrorTip("取消当前操作");
                    }
                }
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
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

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string UserId_Manager = row.Cells["UserId_Manager"].Value.ToString();
                string Name_Manager = row.Cells["Name_Manager"].Value.ToString();
                string Account_Manager = row.Cells["Account_Manager"].Value.ToString();
                string Phone_Manager = row.Cells["Phone_Manager"].Value.ToString();
                string Address_Manager = row.Cells["Address_Manager"].Value.ToString();
                string Sex_Manager = row.Cells["Sex_Manager"].Value.ToString();
                string Position_Manager = row.Cells["Position_Manager"].Value.ToString();
                UserId = int.Parse(UserId_Manager);
                if (Sex_Manager == "女")
                {
                    rbFemale.Checked = true;
                }
                else
                {
                    rbMale.Checked = true;
                }
                UserName.Text = Name_Manager;
                Account.Text = Account_Manager;
                Phone.Text = Phone_Manager;
                Address.Text = Address_Manager;
                Position.Text = Position_Manager;
            }
        }

        private void uiSymbolButton2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text))
            {
                ShowWarningDialog("姓名不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(Account.Text))
            {
                ShowWarningDialog("账号不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(Password.Text))
            {
                ShowWarningDialog("密码不能为空");
                return;
            }
            else if (string.IsNullOrEmpty(Phone.Text))
            {
                ShowWarningDialog("电话不能为空");
                return;
            }

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Sys_User sys_User = new Sys_User();
            int Sex_Manager = 0;
            if (rbMale.Checked == true)
            {
                Sex_Manager = 0;
            }
            else
            {
                Sex_Manager = 1;
            }
            //姓名
            sys_User.Name = UserName.Text;
            //性别
            sys_User.Sex = Sex_Manager;
            //账号
            sys_User.Account = Account.Text;
            //密码
            sys_User.Password = Password.Text;
            //电话
            sys_User.Phone = Phone.Text;
            //职位
            sys_User.Position = Position.Text;
            //地址
            sys_User.Address = Address.Text;
            //创建时间
            sys_User.CreateTime = DateTime.Now;
            //是否删除
            sys_User.IsDelete = 0;
            //添加数据
            capProjectDb.Sys_User.InsertOnSubmit(sys_User);
            //保存数据
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("添加成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text))
            {
                ShowWarningDialog("姓名不能为空");
                return;
            }
            //else if (string.IsNullOrEmpty(Account.Text))
            //{
            //    ShowWarningDialog("账号不能为空");
            //    return;
            //}
            //else if (string.IsNullOrEmpty(Password.Text))
            //{
            //    ShowWarningDialog("密码不能为空");
            //    return;
            //}
            else if (string.IsNullOrEmpty(Phone.Text))
            {
                ShowWarningDialog("电话不能为空");
                return;
            }

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Sys_User sys_User = capProjectDb.Sys_User.Where(t => t.UserId == UserId).FirstOrDefault();
            int Sex_Manager = 0;
            if (rbFemale.Checked == true)
            {
                Sex_Manager = 0;
            }
            else
            {
                Sex_Manager = 1;
            }
            //姓名
            sys_User.Name = UserName.Text;
            //性别
            sys_User.Sex = Sex_Manager;
            //账号
            //sys_User.Account = Account.Text;
            //密码
            //sys_User.Password = Password.Text;
            //电话
            sys_User.Phone = Phone.Text;
            //职位
            sys_User.Position = Position.Text;
            //地址
            sys_User.Address = Address.Text;
            //保存数据
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            rbFemale.Checked = false;
            rbMale.Checked = false;
            uiRadioButton1.Checked = true;
            Password.Text = null;
            UserName.Text = null;
            Account.Text = null;
            Phone.Text = null;
            Address.Text = null;
            Position.Text = null;
            UserId = null;
        }
    }
}
