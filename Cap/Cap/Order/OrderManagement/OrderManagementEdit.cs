﻿using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.Order.OrderManagement
{
    public partial class OrderManagementEdit : UIEditForm
    {
        public OrderManagementEdit(string Column1, string Column2, string Column3)
        {
            InitializeComponent();

            edtName.Text = Column1;
            uiTextBox2.Text = Column2;
            uiTextBox1.Text = Column3;

        }
    }
}
