namespace Cap.BasicSettings.Specifications
{
    partial class SpecificationsEdit
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("米");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("卷");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("尺");
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.edtName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiComboTreeView1 = new Sunny.UI.UIComboTreeView();
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
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(268, 273);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 16);
            this.uiLabel1.TabIndex = 81;
            this.uiLabel1.Text = "长度(米)";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiTextBox1.Location = new System.Drawing.Point(362, 265);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(170, 29);
            this.uiTextBox1.TabIndex = 80;
            this.uiTextBox1.Text = "0";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            this.uiTextBox1.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(268, 216);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(39, 16);
            this.uiLabel4.TabIndex = 79;
            this.uiLabel4.Text = "单位";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.edtName.TabIndex = 77;
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
            this.uiLabel2.TabIndex = 78;
            this.uiLabel2.Text = "材料名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView1
            // 
            this.uiComboTreeView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView1.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiComboTreeView1.Location = new System.Drawing.Point(362, 207);
            this.uiComboTreeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView1.Name = "uiComboTreeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "米";
            treeNode2.Name = "节点1";
            treeNode2.Text = "卷";
            treeNode3.Name = "节点2";
            treeNode3.Text = "尺";
            this.uiComboTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.uiComboTreeView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView1.Size = new System.Drawing.Size(170, 29);
            this.uiComboTreeView1.SymbolSize = 24;
            this.uiComboTreeView1.TabIndex = 82;
            this.uiComboTreeView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView1.Watermark = "";
            // 
            // SpecificationsEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiComboTreeView1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.uiLabel2);
            this.Name = "SpecificationsEdit";
            this.Text = "编辑";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel2, 0);
            this.Controls.SetChildIndex(this.edtName, 0);
            this.Controls.SetChildIndex(this.uiLabel4, 0);
            this.Controls.SetChildIndex(this.uiTextBox1, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.Controls.SetChildIndex(this.uiComboTreeView1, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboTreeView uiComboTreeView1;
    }
}