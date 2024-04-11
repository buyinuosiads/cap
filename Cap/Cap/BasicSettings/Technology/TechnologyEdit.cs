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

namespace Cap.BasicSettings.Technology
{
    public partial class TechnologyEdit : UIEditForm
    {

        public TechnologyEdit(string Column1, string zhuliao, string fuliao)
        {
            InitializeComponent();
            edtName.Text = Column1;


            if (!string.IsNullOrEmpty(zhuliao))
            {
                string[] role = zhuliao.Split(';');
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
            uiComboTreeView1.Text = zhuliao;



            if (!string.IsNullOrEmpty(fuliao))
            {
                string[] role = fuliao.Split(';');
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
            uiComboTreeView3.Text = fuliao;



        }
    }
}
