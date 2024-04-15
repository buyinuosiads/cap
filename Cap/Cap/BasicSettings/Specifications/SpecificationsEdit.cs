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

namespace Cap.BasicSettings.Specifications
{
    public partial class SpecificationsEdit : UIEditForm
    {
        public SpecificationsEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();

            edtName.Text = Column1;
            uiComboTreeView1.Text = Column2;
            uiTextBox1.Text = Column3;
        }
    }
}
