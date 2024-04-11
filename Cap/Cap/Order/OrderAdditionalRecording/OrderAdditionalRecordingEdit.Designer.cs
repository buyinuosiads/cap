namespace Cap.Order.OrderAdditionalRecording
{
    partial class OrderAdditionalRecordingEdit
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
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(362, 156);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(170, 29);
            this.edtName.TabIndex = 89;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(268, 164);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 90;
            this.uiLabel2.Text = "订单补录";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderAdditionalRecordingEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "OrderAdditionalRecordingEdit";
            this.Text = "编辑";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel2;
    }
}