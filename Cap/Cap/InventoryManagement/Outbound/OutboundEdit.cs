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

namespace Cap.InventoryManagement.Outbound
{
    public partial class OutboundEdit : UIEditForm
    {
        public OutboundEdit(string Column1, string Column2, string Column3, string Column4)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiTextBox2.Text = Column2;
            uiTextBox1.Text = Column3;
            uiTextBox3.Text = Column4;

        }
    }
}
