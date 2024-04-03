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
        public TechnologyEdit(string Column1)
        {
            InitializeComponent();
            edtName.Text = Column1;
        }
    }
}
