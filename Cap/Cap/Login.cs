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

            IsLogin = true;
            Nav form = new Nav();
            form.Show();

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
