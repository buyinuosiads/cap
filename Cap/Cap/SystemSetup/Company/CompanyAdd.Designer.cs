namespace Cap.SystemSetup
{
    partial class CompanyAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.edtAddress = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.edtDate = new Sunny.UI.UIDatePicker();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cbDepartment = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.edtAge = new Sunny.UI.UITextBox();
            this.rbFemale = new Sunny.UI.UIRadioButton();
            this.rbMale = new Sunny.UI.UIRadioButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 299);
            this.pnlBtm.Size = new System.Drawing.Size(502, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(259, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // edtAddress
            // 
            this.edtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAddress.Font = new System.Drawing.Font("宋体", 12F);
            this.edtAddress.Location = new System.Drawing.Point(131, 252);
            this.edtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtAddress.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtAddress.Name = "edtAddress";
            this.edtAddress.Padding = new System.Windows.Forms.Padding(5);
            this.edtAddress.ShowText = false;
            this.edtAddress.Size = new System.Drawing.Size(340, 29);
            this.edtAddress.TabIndex = 23;
            this.edtAddress.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtAddress.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(37, 256);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(39, 16);
            this.uiLabel1.TabIndex = 28;
            this.uiLabel1.Text = "住址";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtDate
            // 
            this.edtDate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.edtDate.FillColor = System.Drawing.Color.White;
            this.edtDate.Font = new System.Drawing.Font("宋体", 12F);
            this.edtDate.Location = new System.Drawing.Point(131, 213);
            this.edtDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtDate.MaxLength = 10;
            this.edtDate.MinimumSize = new System.Drawing.Size(63, 0);
            this.edtDate.Name = "edtDate";
            this.edtDate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.edtDate.Size = new System.Drawing.Size(170, 29);
            this.edtDate.SymbolDropDown = 61555;
            this.edtDate.SymbolNormal = 61555;
            this.edtDate.SymbolSize = 24;
            this.edtDate.TabIndex = 22;
            this.edtDate.Text = "2020-05-08";
            this.edtDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtDate.Value = new System.DateTime(2020, 5, 8, 0, 0, 0, 0);
            this.edtDate.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(37, 217);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(39, 16);
            this.uiLabel6.TabIndex = 27;
            this.uiLabel6.Text = "生日";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(37, 177);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(39, 16);
            this.uiLabel5.TabIndex = 26;
            this.uiLabel5.Text = "部门";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DataSource = null;
            this.cbDepartment.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbDepartment.FillColor = System.Drawing.Color.White;
            this.cbDepartment.Font = new System.Drawing.Font("宋体", 12F);
            this.cbDepartment.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbDepartment.Items.AddRange(new object[] {
            "研发部",
            "采购部",
            "生产部",
            "销售部",
            "人事部",
            "财务部",
            "行政部",
            "其他"});
            this.cbDepartment.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbDepartment.Location = new System.Drawing.Point(131, 173);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDepartment.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbDepartment.Size = new System.Drawing.Size(170, 29);
            this.cbDepartment.SymbolSize = 24;
            this.cbDepartment.TabIndex = 20;
            this.cbDepartment.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbDepartment.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(37, 137);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(39, 16);
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "年龄";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtAge
            // 
            this.edtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAge.Font = new System.Drawing.Font("宋体", 12F);
            this.edtAge.Location = new System.Drawing.Point(131, 133);
            this.edtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtAge.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtAge.Name = "edtAge";
            this.edtAge.Padding = new System.Windows.Forms.Padding(5);
            this.edtAge.ShowText = false;
            this.edtAge.Size = new System.Drawing.Size(170, 29);
            this.edtAge.TabIndex = 19;
            this.edtAge.Text = "0";
            this.edtAge.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtAge.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.edtAge.Watermark = "";
            // 
            // rbFemale
            // 
            this.rbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbFemale.Location = new System.Drawing.Point(219, 93);
            this.rbFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbFemale.Size = new System.Drawing.Size(82, 29);
            this.rbFemale.TabIndex = 18;
            this.rbFemale.Text = "女";
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbMale.Location = new System.Drawing.Point(131, 93);
            this.rbMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbMale.Size = new System.Drawing.Size(82, 29);
            this.rbMale.TabIndex = 17;
            this.rbMale.Text = "男";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(37, 97);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(39, 16);
            this.uiLabel3.TabIndex = 24;
            this.uiLabel3.Text = "性别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(131, 53);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(340, 29);
            this.edtName.TabIndex = 16;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(37, 57);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(39, 16);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompanyAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 357);
            this.Controls.Add(this.edtAddress);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.edtDate);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "CompanyAdd";
            this.Text = "CompanyAdd";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.rbMale, 0);
            this.Controls.SetChildIndex(this.rbFemale, 0);
            this.Controls.SetChildIndex(this.edtAge, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.cbDepartment, 0);
            this.Controls.SetChildIndex(this.uiLabel5, 0);
            this.Controls.SetChildIndex(this.uiLabel6, 0);
            this.Controls.SetChildIndex(this.edtDate, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.edtAddress, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox edtAddress;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDatePicker edtDate;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cbDepartment;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox edtAge;
        private Sunny.UI.UIRadioButton rbFemale;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel2;
    }
}