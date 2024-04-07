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
using static Cap.SystemSetup.Menu.MenuBarAdd;

namespace Cap.SystemSetup
{
    public partial class UserAdd : UIEditForm
    {
        //CapProjectDataContext capProjectDb = new CapProjectDataContext();
        public UserAdd()
        {
            InitializeComponent();
            //List<Sys_Role> sys_Role = capProjectDb.Sys_Role.ToList();


            //IList<Info> infoList = new List<Info>();

            //foreach (Sys_Role role in sys_Role)
            //{
            //    infoList.Add(new Info() { Id = role.RoleId.ToString(), Name = role.RoleName });
            //}

            //Position.ValueMember = "Id";
            //Position.DisplayMember = "Name";
            //Position.DataSource = infoList;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            //int sex = 0;
            //bool nan = rbMale.Checked;
            //if (nan) { sex = 0; }
            //bool nv = rbFemale.Checked;
            //if (nv) { sex = 1; }

            //Sys_User sys_User = new Sys_User();
            //sys_User.Name = Name.Text;
            //sys_User.Account = Account.Text;
            //sys_User.Password = Password.Text;
            //sys_User.Address = Address.Text;
            //sys_User.CreateTime = DateTime.Now;
            //sys_User.Sex = sex;
            //sys_User.Phone = Phone.Text;
            //sys_User.Position = Position.Text;
            //capProjectDb.Sys_User.InsertOnSubmit(sys_User);
            //capProjectDb.SubmitChanges();

        }
    }
}
