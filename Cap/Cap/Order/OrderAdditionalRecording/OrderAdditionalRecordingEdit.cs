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

namespace Cap.Order.OrderAdditionalRecording
{
    public partial class OrderAdditionalRecordingEdit : UIEditForm
    {
        public OrderAdditionalRecordingEdit(string rowData)
        {
            InitializeComponent();

            edtName.Text = rowData;

        }
    }
}
