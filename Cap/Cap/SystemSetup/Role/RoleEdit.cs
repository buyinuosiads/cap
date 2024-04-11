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
using static Cap.SystemSetup.Menu.MenuBarAdd;

namespace Cap.SystemSetup.Role
{
    public partial class RoleEdit : UIEditForm
    {

        //CapProjectDataContext capProjectDb = new CapProjectDataContext();
        string checkItem = string.Empty;
        string _RoleId = string.Empty;
        string _MenuName = string.Empty;
        public RoleEdit(string RoleId, string RoleName)
        {
            InitializeComponent();
            Name.Text = RoleName;
            //Sys_Role sys_Role = capProjectDb.Sys_Role.Where(t => t.RoleId.Equals(RoleId)).FirstOrDefault();
            //uiComboTreeView2.Text = sys_Role.MenuName;
            //Name.Text = sys_Role.RoleName;

            //_RoleId = RoleId;
            //_MenuName = sys_Role.MenuName;
            //checkItem = sys_Role.MenuName;
        }



        private void uiComboTreeView2_NodesSelected(object sender, System.Windows.Forms.TreeNodeCollection nodes)
        {
            checkItem = string.Empty;
            //返回的nodes为TreeView的所有节点，需循环判断
            foreach (TreeNode item in nodes)
            {
                if (item.Checked)
                {
                    Console.WriteLine(item.ToString());
                    checkItem += item.Text + ";";
                }

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Sys_Role sys_Role = capProjectDb.Sys_Role.Where(t => t.RoleId.Equals(_RoleId)).FirstOrDefault();
            //sys_Role.MenuName = checkItem;
            //sys_Role.RoleName = Name.Text;
            //capProjectDb.SubmitChanges();
            //ShowSuccessTip("修改成功");

        }

        private void RoleEdit_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_MenuName))
            {
                string[] role = _MenuName.Split(';');
                foreach (TreeNode item in uiComboTreeView2.Nodes)
                {
                    string im = item.ToString().Replace("TreeNode: ", null);
                    for (int i = 0; i < role.Length; i++)
                    {

                        if (im == role[i].ToString())
                        {
                            item.Checked = true;
                        }

                    }
                }

            }

        }
    }
}
