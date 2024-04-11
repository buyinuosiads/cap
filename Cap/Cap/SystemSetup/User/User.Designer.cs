namespace Cap.SystemSetup
{
    partial class User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.edtName = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiDataGridView1
            // 
            this.uiDataGridView1.AllowUserToAddRows = false;
            this.uiDataGridView1.AllowUserToDeleteRows = false;
            this.uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Account,
            this.Column2,
            this.Column3,
            this.Sex,
            this.Position,
            this.Search,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(3, 23);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1064, 448);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account.DataPropertyName = "Account";
            this.Account.HeaderText = "账号";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "电话";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "地址";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "职位";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // Search
            // 
            this.Search.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "查看";
            this.Search.DefaultCellStyle = dataGridViewCellStyle3;
            this.Search.HeaderText = "查看";
            this.Search.Name = "Search";
            this.Search.ReadOnly = true;
            this.Search.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "编辑";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Edit.HeaderText = "编辑";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "删除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.HeaderText = "删除";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.uiDataGridView1);
            this.groupBox1.Controls.Add(this.uiPagination1);
            this.groupBox1.Location = new System.Drawing.Point(0, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 509);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // uiPagination1
            // 
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(3, 471);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.PagerCount = 11;
            this.uiPagination1.PageSize = 50;
            this.uiPagination1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(1064, 35);
            this.uiPagination1.TabIndex = 7;
            this.uiPagination1.Text = "uiDataGridPage1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPagination1.TotalCount = 40000;
            this.uiPagination1.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.uiPagination1_PageChanged);
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton2);
            this.uiCheckBoxGroup1.Controls.Add(this.edtName);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton1);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxGroup1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(0, 0);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1041, 101);
            this.uiCheckBoxGroup1.TabIndex = 5;
            this.uiCheckBoxGroup1.Text = null;
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(55, 35);
            this.edtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.edtName.Name = "edtName";
            this.edtName.Padding = new System.Windows.Forms.Padding(5);
            this.edtName.ShowText = false;
            this.edtName.Size = new System.Drawing.Size(128, 29);
            this.edtName.TabIndex = 30;
            this.edtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.edtName.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(190, 33);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "查找";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(9, 41);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(39, 16);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(310, 33);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.Symbol = 61543;
            this.uiSymbolButton2.TabIndex = 31;
            this.uiSymbolButton2.Text = "增加";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // User
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Name = "User";
            this.Text = "用户管理";
            this.Initialize += new System.EventHandler(this.Company_Initialize);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIPagination uiPagination1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILabel uiLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}