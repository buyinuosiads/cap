namespace Cap.SystemSetup.Role
{
    partial class RoleEdit
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("公司管理");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("用户管理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("菜单管理");
            this.Name = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiComboTreeView2 = new Sunny.UI.UIComboTreeView();
            this.uiLabel1 = new Sunny.UI.UILabel();
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
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Name
            // 
            this.Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name.EnterAsTab = true;
            this.Name.Font = new System.Drawing.Font("宋体", 12F);
            this.Name.Location = new System.Drawing.Point(224, 150);
            this.Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name.MinimumSize = new System.Drawing.Size(1, 16);
            this.Name.Name = "Name";
            this.Name.Padding = new System.Windows.Forms.Padding(5);
            this.Name.ShowText = false;
            this.Name.Size = new System.Drawing.Size(340, 29);
            this.Name.TabIndex = 53;
            this.Name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Name.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(146, 157);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(71, 16);
            this.uiLabel3.TabIndex = 54;
            this.uiLabel3.Text = "角色名称";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboTreeView2
            // 
            this.uiComboTreeView2.CheckBoxes = true;
            this.uiComboTreeView2.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboTreeView2.FillColor = System.Drawing.Color.White;
            this.uiComboTreeView2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiComboTreeView2.Location = new System.Drawing.Point(224, 198);
            this.uiComboTreeView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboTreeView2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboTreeView2.Name = "uiComboTreeView2";
            treeNode1.Name = "公司管理";
            treeNode1.Text = "公司管理";
            treeNode2.Name = "用户管理";
            treeNode2.Text = "用户管理";
            treeNode3.Name = "菜单管理";
            treeNode3.Text = "菜单管理";
            this.uiComboTreeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.uiComboTreeView2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboTreeView2.Size = new System.Drawing.Size(340, 29);
            this.uiComboTreeView2.SymbolSize = 24;
            this.uiComboTreeView2.TabIndex = 66;
            this.uiComboTreeView2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboTreeView2.Watermark = "";
            this.uiComboTreeView2.NodesSelected += new Sunny.UI.UIComboTreeView.OnNodesSelected(this.uiComboTreeView2_NodesSelected);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(146, 203);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 16);
            this.uiLabel1.TabIndex = 67;
            this.uiLabel1.Text = "分配菜单";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoleEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiComboTreeView2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.uiLabel3); 
            this.Text = "RoleEdit";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.RoleEdit_Load);
            this.Controls.SetChildIndex(this.pnlBtm, 0);
            this.Controls.SetChildIndex(this.uiLabel3, 0);
            this.Controls.SetChildIndex(this.Name, 0);
            this.Controls.SetChildIndex(this.uiComboTreeView2, 0);
            this.Controls.SetChildIndex(this.uiLabel1, 0);
            this.pnlBtm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox Name;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboTreeView uiComboTreeView2;
        private Sunny.UI.UILabel uiLabel1;
    }
}