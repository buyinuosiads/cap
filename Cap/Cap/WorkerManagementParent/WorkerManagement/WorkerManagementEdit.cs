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

namespace Cap.WorkerManagementParent.WorkerManagement
{
    public partial class WorkerManagementEdit : UIEditForm
    {
        public WorkerManagementEdit(string rowData, string Column2, string Column3)
        {
            InitializeComponent();

            MenuText.Text = rowData;
            uiTextBox1.Text = Column2;
            uiTextBox2.Text = Column3;
        }
    }
}
