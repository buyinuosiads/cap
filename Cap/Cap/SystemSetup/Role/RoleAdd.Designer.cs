namespace Cap.SystemSetup.Role
{
    partial class RoleAdd
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
            this.MenuText = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 91);
            this.pnlBtm.Size = new System.Drawing.Size(445, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(202, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MenuText
            // 
            this.MenuText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MenuText.EnterAsTab = true;
            this.MenuText.Font = new System.Drawing.Font("宋体", 12F);
            this.MenuText.Location = new System.Drawing.Point(82, 47);
            this.MenuText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuText.MinimumSize = new System.Drawing.Size(1, 16);
            this.MenuText.Name = "MenuText";
            this.MenuText.Padding = new System.Windows.Forms.Padding(5);
            this.MenuText.ShowText = false;
            this.MenuText.Size = new System.Drawing.Size(340, 29);
            this.MenuText.TabIndex = 51;
            this.MenuText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MenuText.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(4, 54);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(71, 16);
            this.uiLabel3.TabIndex = 52;
            this.uiLabel3.Text = "菜单名称";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoleAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(447, 149);
            this.Controls.Add(this.MenuText);
            this.Controls.Add(this.uiLabel3);
            this.Name = "RoleAdd";
            this.Text = "RoleAdd";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.MenuText, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox MenuText;
        private Sunny.UI.UILabel uiLabel3;
    }
}