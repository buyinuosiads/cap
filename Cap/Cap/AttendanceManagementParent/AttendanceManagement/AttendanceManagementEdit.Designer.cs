namespace Cap.AttendanceManagementParent.AttendanceManagement
{
    partial class AttendanceManagementEdit
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
            this.Account = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.Password = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.Name = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Size = new System.Drawing.Size(798, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(670, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(555, 12);
            // 
            // Account
            // 
            this.Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Account.EnterAsTab = true;
            this.Account.Font = new System.Drawing.Font("宋体", 12F);
            this.Account.Location = new System.Drawing.Point(253, 165);
            this.Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account.MinimumSize = new System.Drawing.Size(1, 16);
            this.Account.Name = "Account";
            this.Account.Padding = new System.Windows.Forms.Padding(5);
            this.Account.ShowText = false;
            this.Account.Size = new System.Drawing.Size(340, 29);
            this.Account.TabIndex = 46;
            this.Account.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(175, 171);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(71, 16);
            this.uiLabel8.TabIndex = 48;
            this.uiLabel8.Text = "考勤天数";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.EnterAsTab = true;
            this.Password.Font = new System.Drawing.Font("宋体", 12F);
            this.Password.Location = new System.Drawing.Point(253, 207);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(5);
            this.Password.ShowText = false;
            this.Password.Size = new System.Drawing.Size(340, 29);
            this.Password.TabIndex = 47;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(175, 213);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(55, 16);
            this.uiLabel7.TabIndex = 49;
            this.uiLabel7.Text = "考勤人";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Name
            // 
            this.Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name.EnterAsTab = true;
            this.Name.Font = new System.Drawing.Font("宋体", 12F);
            this.Name.Location = new System.Drawing.Point(253, 126);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name.MinimumSize = new System.Drawing.Size(1, 16);
            this.Name.Name = "Name";
            this.Name.Padding = new System.Windows.Forms.Padding(5);
            this.Name.ShowText = false;
            this.Name.Size = new System.Drawing.Size(340, 29);
            this.Name.TabIndex = 44;
            this.Name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Name.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(175, 133);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(39, 16);
            this.uiLabel2.TabIndex = 45;
            this.uiLabel2.Text = "考勤";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AttendanceManagementEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.uiLabel2); 
            this.Text = "编辑";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.Name, 0);
            this.Controls.SetChildIndex(this.uiLabel7, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            this.Controls.SetChildIndex(this.uiLabel8, 0);
            this.Controls.SetChildIndex(this.Account, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox Account;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox Name;
        private Sunny.UI.UILabel uiLabel2;
    }
}