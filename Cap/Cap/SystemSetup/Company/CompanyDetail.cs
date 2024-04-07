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

namespace Cap.SystemSetup
{
    public partial class CompanyDetail : UIEditForm
    {
        public CompanyDetail(string Column2)
        {
            InitializeComponent();
            edtName.Text = Column2;
        }
    }
}
