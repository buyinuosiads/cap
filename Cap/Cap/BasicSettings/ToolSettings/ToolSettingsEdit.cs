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

namespace Cap.BasicSettings.ToolSettings
{
    public partial class ToolSettingsEdit : UIEditForm
    {
        public ToolSettingsEdit(string Column1, string Column2, string Column3, string fukuan, string xishu, string tangtou)
        {
            InitializeComponent();

            edtName.Text = Column1;
            edtAge.Text = Column2;
            uiTextBox1.Text = Column3;


            if (!string.IsNullOrEmpty(fukuan))
            {
                string[] role = fukuan.Split(';');
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
            uiComboTreeView2.Text = fukuan;



            if (!string.IsNullOrEmpty(xishu))
            {
                string[] role = xishu.Split(';');
                foreach (TreeNode item in uiComboTreeView1.Nodes)
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
            uiComboTreeView1.Text = xishu;




            if (!string.IsNullOrEmpty(tangtou))
            {
                string[] role = tangtou.Split(';');
                foreach (TreeNode item in uiComboTreeView3.Nodes)
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
            uiComboTreeView3.Text = tangtou;
            


        }
    }
}
