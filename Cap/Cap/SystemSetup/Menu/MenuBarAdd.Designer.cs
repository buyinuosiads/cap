namespace Cap.SystemSetup.Menu
{
    partial class MenuBarAdd
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
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.MenuText = new Sunny.UI.UITextBox();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 91);
            this.pnlBtm.Size = new System.Drawing.Size(451, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(208, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(15, 54);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(71, 16);
            this.uiLabel3.TabIndex = 50;
            this.uiLabel3.Text = "菜单名称";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuText
            // 
            this.MenuText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MenuText.EnterAsTab = true;
            this.MenuText.Font = new System.Drawing.Font("宋体", 12F);
            this.MenuText.Location = new System.Drawing.Point(93, 47);
            this.MenuText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuText.MinimumSize = new System.Drawing.Size(1, 16);
            this.MenuText.Name = "MenuText";
            this.MenuText.Padding = new System.Windows.Forms.Padding(5);
            this.MenuText.ShowText = false;
            this.MenuText.Size = new System.Drawing.Size(340, 29);
            this.MenuText.TabIndex = 43;
            this.MenuText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MenuText.Watermark = "";
            // 
            // MenuBarAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(453, 149);
            this.Controls.Add(this.MenuText);
            this.Controls.Add(this.uiLabel3);
            this.Name = "MenuBarAdd";
            this.Text = "MenuBarAdd";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.MenuText, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox MenuText;
    }
}