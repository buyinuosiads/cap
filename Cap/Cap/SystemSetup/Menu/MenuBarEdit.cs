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

namespace Cap.SystemSetup.Menu
{
    public partial class MenuBarEdit : UIEditForm
    {
        public MenuBarEdit(string rowData)
        {
            InitializeComponent();
            MenuText.Text = rowData;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
