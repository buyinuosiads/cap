using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap
{
    public partial class UserDetail : UIEditForm
    {
        public UserDetail(string Column1, string _Account, string Column2, string Column3, string Sex, string _Position)
        {
            InitializeComponent();

            if (Sex == "女")
            {
                rbFemale.Checked = true;
            }
            Name.Text = Column1;
            Account.Text = _Account;
            Phone.Text = Column2;
            uiTextBox1.Text = _Position;
            Address.Text = Column3;

        }
    }
}
