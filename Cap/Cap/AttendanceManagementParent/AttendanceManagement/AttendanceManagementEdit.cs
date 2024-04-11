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

namespace Cap.AttendanceManagementParent.AttendanceManagement
{
    public partial class AttendanceManagementEdit : UIEditForm
    {
        public AttendanceManagementEdit(string rowData, string Column2, string Column3)
        {
            InitializeComponent();

            Name.Text = rowData;
            Account.Text = Column2;
            Password.Text = Column3;
        }
    }
}
