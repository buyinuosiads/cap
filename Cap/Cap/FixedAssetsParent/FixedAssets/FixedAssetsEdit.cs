using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.FixedAssetsParent.FixedAssets
{
    public partial class FixedAssetsEdit : UIEditForm
    {
        public FixedAssetsEdit(string rowData, string Column2, string Column3, string Column4, string Column5, string Column6, string Column7)
        {
            InitializeComponent();
            edtName.Text = rowData;
            uiTextBox2.Text = Column2;
            uiTextBox1.Text = Column3;
            uiTextBox3.Text = Column4;
            uiTextBox4.Text = Column5;
            uiTextBox5.Text = Column6;
            uiTextBox6.Text = Column7;

        }
    }
}
