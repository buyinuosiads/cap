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

namespace Cap.Finance.FinancialStatements
{
    public partial class FinancialStatementsEdit : UIEditForm
    {
        public FinancialStatementsEdit(string rowData, string Column2, string Column3, string Column4, string Column5)
        {
            InitializeComponent();
            edtName.Text = rowData;
            uiTextBox2.Text = Column2;
            uiTextBox1.Text = Column3;
            uiTextBox3.Text = Column4;
            uiTextBox4.Text = Column5;

        }
    }
}
