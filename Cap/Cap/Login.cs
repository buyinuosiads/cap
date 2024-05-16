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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap
{
    public partial class Login : UILoginForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void FLogin_ButtonLoginClick(object sender, System.EventArgs e)
        {


            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Sys_User _User = capProjectDb.Sys_User.Where(t => t.Account == "admin" && t.Password == "123456" && t.IsDelete == 0).FirstOrDefault();
            //Sys_User _User = capProjectDb.Sys_User.Where(t => t.Account == UserName && t.Password == Password && t.IsDelete == 0).FirstOrDefault();
            if (_User != null)
            {
                IsLogin = true;
                Nav form = new Nav(_User.Name, _User.Position);
                form.Show();
                this.Hide(); // 隐藏当前窗体，不关闭
            }
            else
            {
                ShowErrorTip("用户名或者密码错误。");
            }

            //if (UserName == "1" && Password == "1")
            //{
            //    IsLogin = true;
            //    Nav form = new Nav();
            //    form.Show();
            //}
            //else
            //{
            //    ShowErrorTip("用户名或者密码错误。");
            //}
        }

    }



}
