﻿using Sunny.UI;
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

namespace Cap.Order.OrderSplitting
{
    public partial class OrderSplittingEdit : UIEditForm
    {
        public OrderSplittingEdit(string rowData, string Column2, string Column3)
        {
            InitializeComponent();

            edtName.Text = rowData;
            uiTextBox2.Text = Column2;
            uiTextBox1.Text = Column3;
        }
    }
}
