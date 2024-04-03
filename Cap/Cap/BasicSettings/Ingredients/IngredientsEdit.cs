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

namespace Cap.BasicSettings.Ingredients
{
    public partial class IngredientsEdit : UIEditForm
    {
        public IngredientsEdit(string Column1, string Column2)
        {
            InitializeComponent();
            edtName.Text = Column1;
            edtAge.Text = Column2;
        }
    }
}
