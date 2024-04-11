namespace Cap.SystemSetup
{
    partial class WidthOfClothAdd
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
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.edtAge = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiComboBox4 = new Sunny.UI.UIComboBox();
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
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(190, 87);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(170, 29);
            this.edtName.TabIndex = 16;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            this.edtName.TextChanged += new System.EventHandler(this.edtName_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(96, 95);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "幅宽名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(96, 153);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(71, 16);
            this.uiLabel4.TabIndex = 25;
            this.uiLabel4.Text = "幅宽大小";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // edtAge
            // 
            this.edtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAge.Font = new System.Drawing.Font("宋体", 12F);
            this.edtAge.Location = new System.Drawing.Point(190, 145);
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
            this.edtAge.TextChanged += new System.EventHandler(this.edtAge_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(96, 208);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 16);
            this.uiLabel1.TabIndex = 27;
            this.uiLabel1.Text = "幅宽类型";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox4
            // 
            this.uiComboBox4.DataSource = null;
            this.uiComboBox4.FillColor = System.Drawing.Color.White;
            this.uiComboBox4.FilterMaxCount = 50;
            this.uiComboBox4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiComboBox4.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox4.Items.AddRange(new object[] {
            "前幅",
            "后幅",
            "帽顶",
            "侧幅",
            "檐边"});
            this.uiComboBox4.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox4.Location = new System.Drawing.Point(190, 196);
            this.uiComboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox4.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox4.Name = "uiComboBox4";
            this.uiComboBox4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiComboBox4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            this.uiComboBox4.ShowFilter = true;
            this.uiComboBox4.Size = new System.Drawing.Size(170, 29);
            this.uiComboBox4.SymbolSize = 24;
            this.uiComboBox4.TabIndex = 77;
            this.uiComboBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox4.Watermark = "请选择宽幅类型";
            // 
            // WidthOfClothAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(504, 357);
            this.Controls.Add(this.uiComboBox4);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "WidthOfClothAdd";
            this.Text = "添加";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.WidthOfClothAdd_Load);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.edtAge, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiComboBox4, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox edtAge;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox uiComboBox4;
    }
}