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

namespace Cap.InventoryManagement.Inventory
{
    public partial class InventoryEdit : UIEditForm
    {
        public InventoryEdit(string Column1, string Column2)
        {
            InitializeComponent();
            edtName.Text = Column1;
            uiTextBox2.Text = Column2; 

        }
    }
}
