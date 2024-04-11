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

namespace Cap.AlarmManagementParent.AlarmManagement
{
    public partial class AlarmManagementEdit : UIEditForm
    {
        public AlarmManagementEdit(string Column2, string rowData, string Column3)
        {
            InitializeComponent();

            edtName.Text = Column2;
            uiTextBox2.Text = rowData;
            uiTextBox1.Text = Column3;



        }
    }
}
