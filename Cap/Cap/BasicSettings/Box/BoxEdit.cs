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

namespace Cap.BasicSettings.Box
{
    public partial class BoxEdit : UIEditForm
    {
        public BoxEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiTextBox1.Text = Column2;
            uiTextBox2.Text = Column3;
        }
    }
}
