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

namespace Cap.BasicSettings.Product
{
    public partial class ProductEdit : UIEditForm
    {
        public ProductEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiComboBox4.Text = Column2;
            uiTextBox1.Text = Column3;
        }
    }
}
