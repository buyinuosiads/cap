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
    public partial class RoleAdd : UIEditForm
    {
        //CapProjectDataContext capProjectDb = new CapProjectDataContext();
        public RoleAdd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Sys_Role sys_Role = new Sys_Role();
            //sys_Role.RoleName = MenuText.Text;
            //sys_Role.CreateTime = DateTime.Now;
            //capProjectDb.Sys_Role.InsertOnSubmit(sys_Role);
            //capProjectDb.SubmitChanges();
        }
    }
}
