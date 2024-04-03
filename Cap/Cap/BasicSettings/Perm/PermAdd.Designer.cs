﻿namespace Cap.BasicSettings.Perm
{
    partial class PermAdd
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
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.edtAge = new Sunny.UI.UITextBox();
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pnlBtm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtm
            // 
            this.pnlBtm.Location = new System.Drawing.Point(1, 397);
            this.pnlBtm.Size = new System.Drawing.Size(835, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(707, 12);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(592, 12);
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(273, 225);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(71, 16);
            this.uiLabel4.TabIndex = 29;
            this.uiLabel4.Text = "烫头规格";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.Click += new System.EventHandler(this.uiLabel4_Click);
            // 
            // edtAge
            // 
            this.edtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtAge.Font = new System.Drawing.Font("宋体", 12F);
            this.edtAge.Location = new System.Drawing.Point(367, 217);
            this.edtAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtAge.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtAge.Name = "edtAge";
            this.edtAge.Padding = new System.Windows.Forms.Padding(5);
            this.edtAge.ShowText = false;
            this.edtAge.Size = new System.Drawing.Size(170, 29);
            this.edtAge.TabIndex = 27;
            this.edtAge.Text = "0";
            this.edtAge.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtAge.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.edtAge.Watermark = "";
            this.edtAge.TextChanged += new System.EventHandler(this.edtAge_TextChanged);
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(367, 152);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(170, 29);
            this.edtName.TabIndex = 26;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            this.edtName.TextChanged += new System.EventHandler(this.edtName_TextChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(273, 160);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 28;
            this.uiLabel2.Text = "烫头名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.Click += new System.EventHandler(this.uiLabel2_Click);
            // 
            // PermAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(837, 455);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.edtAge);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "PermAdd";
            this.Text = "PermAdd";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.PermAdd_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.edtAge, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox edtAge;
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel2;
    }
}