namespace Cap.BasicSettings.ToolSettings
{
    partial class ToolSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSettings));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("系数1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("系数2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("系数3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("系数4");
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Id_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolName_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WideRating_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaultTolerant_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breadth_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermName_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateName_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.CreateName = new Sunny.UI.UITextBox();
            this.CreateTime = new Sunny.UI.UITextBox();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.PermName = new Sunny.UI.UIComboTreeView();
            this.Coefficient = new Sunny.UI.UIComboTreeView();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.Breadth = new Sunny.UI.UIComboTreeView();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.FaultTolerant = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.WideRating = new Sunny.UI.UITextBox();
            this.ToolName = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnAdd = new Sunny.UI.UISymbolButton();
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
            this.Id_Manager,
            this.ToolName_Manager,
            this.WideRating_Manager,
            this.FaultTolerant_Manager,
            this.Breadth_Manager,
            this.Coefficient_Manager,
            this.PermName_Manager,
            this.CreateTime_Manager,
            this.CreateName_Manager,
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
            this.uiDataGridView1.Size = new System.Drawing.Size(1064, 365);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellClick);
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
            // 
            // Id_Manager
            // 
            this.Id_Manager.DataPropertyName = "Id_Manager";
            this.Id_Manager.HeaderText = "Id_Manager";
            this.Id_Manager.Name = "Id_Manager";
            this.Id_Manager.ReadOnly = true;
            this.Id_Manager.Visible = false;
            // 
            // ToolName_Manager
            // 
            this.ToolName_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToolName_Manager.DataPropertyName = "ToolName_Manager";
            this.ToolName_Manager.HeaderText = "刀具名称";
            this.ToolName_Manager.Name = "ToolName_Manager";
            this.ToolName_Manager.ReadOnly = true;
            // 
            // WideRating_Manager
            // 
            this.WideRating_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WideRating_Manager.DataPropertyName = "WideRating_Manager";
            this.WideRating_Manager.HeaderText = "幅宽定额";
            this.WideRating_Manager.Name = "WideRating_Manager";
            this.WideRating_Manager.ReadOnly = true;
            // 
            // FaultTolerant_Manager
            // 
            this.FaultTolerant_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FaultTolerant_Manager.DataPropertyName = "FaultTolerant_Manager";
            this.FaultTolerant_Manager.HeaderText = "容错值";
            this.FaultTolerant_Manager.Name = "FaultTolerant_Manager";
            this.FaultTolerant_Manager.ReadOnly = true;
            // 
            // Breadth_Manager
            // 
            this.Breadth_Manager.DataPropertyName = "Breadth_Manager";
            this.Breadth_Manager.HeaderText = "幅宽";
            this.Breadth_Manager.Name = "Breadth_Manager";
            this.Breadth_Manager.ReadOnly = true;
            // 
            // Coefficient_Manager
            // 
            this.Coefficient_Manager.DataPropertyName = "Coefficient_Manager";
            this.Coefficient_Manager.HeaderText = "系数";
            this.Coefficient_Manager.Name = "Coefficient_Manager";
            this.Coefficient_Manager.ReadOnly = true;
            // 
            // PermName_Manager
            // 
            this.PermName_Manager.DataPropertyName = "PermName_Manager";
            this.PermName_Manager.HeaderText = "烫头";
            this.PermName_Manager.Name = "PermName_Manager";
            this.PermName_Manager.ReadOnly = true;
            // 
            // CreateTime_Manager
            // 
            this.CreateTime_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime_Manager.DataPropertyName = "CreateTime_Manager";
            this.CreateTime_Manager.HeaderText = "创建时间";
            this.CreateTime_Manager.Name = "CreateTime_Manager";
            this.CreateTime_Manager.ReadOnly = true;
            // 
            // CreateName_Manager
            // 
            this.CreateName_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateName_Manager.DataPropertyName = "CreateName_Manager";
            this.CreateName_Manager.HeaderText = "创建人";
            this.CreateName_Manager.Name = "CreateName_Manager";
            this.CreateName_Manager.ReadOnly = true;
            // 
            // Search
            // 
            this.Search.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "查看";
            this.Search.DefaultCellStyle = dataGridViewCellStyle3;
            this.Search.HeaderText = "操作";
            this.Search.Name = "Search";
            this.Search.ReadOnly = true;
            this.Search.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Search.Visible = false;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "编辑";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle4;
            this.Edit.HeaderText = "操作";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Visible = false;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "删除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.HeaderText = "操作";
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
            this.groupBox1.Location = new System.Drawing.Point(0, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // uiPagination1
            // 
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(3, 388);
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
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton6);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel8);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel7);
            this.uiCheckBoxGroup1.Controls.Add(this.CreateName);
            this.uiCheckBoxGroup1.Controls.Add(this.CreateTime);
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton5);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel6);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel5);
            this.uiCheckBoxGroup1.Controls.Add(this.PermName);
            this.uiCheckBoxGroup1.Controls.Add(this.Coefficient);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup1.Controls.Add(this.Breadth);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel1);
            this.uiCheckBoxGroup1.Controls.Add(this.FaultTolerant);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel4);
            this.uiCheckBoxGroup1.Controls.Add(this.WideRating);
            this.uiCheckBoxGroup1.Controls.Add(this.ToolName);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton1);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup1.Controls.Add(this.btnAdd);
            this.uiCheckBoxGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiCheckBoxGroup1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBoxGroup1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.uiCheckBoxGroup1.Location = new System.Drawing.Point(0, 35);
            this.uiCheckBoxGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiCheckBoxGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            this.uiCheckBoxGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiCheckBoxGroup1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1166, 184);
            this.uiCheckBoxGroup1.TabIndex = 7;
            this.uiCheckBoxGroup1.Text = null;
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton6
            // 
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiButton6.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.uiButton6.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.uiButton6.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.uiButton6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiButton6.Location = new System.Drawing.Point(951, 127);
            this.uiButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.uiButton6.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.uiButton6.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.uiButton6.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.uiButton6.ShowFocusLine = true;
            this.uiButton6.Size = new System.Drawing.Size(108, 35);
            this.uiButton6.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton6.StyleCustomMode = true;
            this.uiButton6.TabIndex = 91;
            this.uiButton6.Text = "清空文本框";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(632, 94);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(55, 16);
            this.uiLabel8.TabIndex = 90;
            this.uiLabel8.Text = "创建人";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(632, 47);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(71, 16);
            this.uiLabel7.TabIndex = 89;
            this.uiLabel7.Text = "创建时间";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateName
            // 
            this.CreateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateName.EnterAsTab = true;
            this.CreateName.Font = new System.Drawing.Font("宋体", 12F);
            this.CreateName.Location = new System.Drawing.Point(710, 86);
            this.CreateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateName.MinimumSize = new System.Drawing.Size(1, 16);
            this.CreateName.Name = "CreateName";
            this.CreateName.Padding = new System.Windows.Forms.Padding(5);
            this.CreateName.ReadOnly = true;
            this.CreateName.ShowText = false;
            this.CreateName.Size = new System.Drawing.Size(206, 29);
            this.CreateName.TabIndex = 32;
            this.CreateName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateName.Watermark = "";
            // 
            // CreateTime
            // 
            this.CreateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateTime.EnterAsTab = true;
            this.CreateTime.Font = new System.Drawing.Font("宋体", 12F);
            this.CreateTime.Location = new System.Drawing.Point(710, 39);
            this.CreateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Padding = new System.Windows.Forms.Padding(5);
            this.CreateTime.ReadOnly = true;
            this.CreateTime.ShowText = false;
            this.CreateTime.Size = new System.Drawing.Size(206, 29);
            this.CreateTime.TabIndex = 31;
            this.CreateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTime.Watermark = "";
            // 
            // uiButton5
            // 
            this.uiButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton5.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButton5.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButton5.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButton5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiButton5.Location = new System.Drawing.Point(845, 127);
            this.uiButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton5.Name = "uiButton5";
            this.uiButton5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.uiButton5.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.uiButton5.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButton5.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.uiButton5.ShowFocusLine = true;
            this.uiButton5.Size = new System.Drawing.Size(100, 35);
            this.uiButton5.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton5.StyleCustomMode = true;
            this.uiButton5.TabIndex = 88;
            this.uiButton5.Text = "修改";
            this.uiButton5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(331, 138);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(39, 16);
            this.uiLabel6.TabIndex = 73;
            this.uiLabel6.Text = "烫头";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(12, 141);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(39, 16);
            this.uiLabel5.TabIndex = 71;
            this.uiLabel5.Text = "系数";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PermName
            // 
            this.PermName.CheckBoxes = true;
            this.PermName.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.PermName.FillColor = System.Drawing.Color.White;
            this.PermName.Font = new System.Drawing.Font("宋体", 12F);
            this.PermName.Location = new System.Drawing.Point(393, 133);
            this.PermName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PermName.MinimumSize = new System.Drawing.Size(63, 0);
            this.PermName.Name = "PermName";
            this.PermName.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.PermName.Size = new System.Drawing.Size(220, 29);
            this.PermName.SymbolSize = 24;
            this.PermName.TabIndex = 72;
            this.PermName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PermName.Watermark = "";
            this.PermName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PermName_MouseClick);
            // 
            // Coefficient
            // 
            this.Coefficient.CheckBoxes = true;
            this.Coefficient.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.Coefficient.FillColor = System.Drawing.Color.White;
            this.Coefficient.Font = new System.Drawing.Font("宋体", 12F);
            this.Coefficient.Location = new System.Drawing.Point(106, 133);
            this.Coefficient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Coefficient.MinimumSize = new System.Drawing.Size(63, 0);
            this.Coefficient.Name = "Coefficient";
            treeNode1.Name = "节点0";
            treeNode1.Text = "系数1";
            treeNode2.Name = "节点1";
            treeNode2.Text = "系数2";
            treeNode3.Name = "节点2";
            treeNode3.Text = "系数3";
            treeNode4.Name = "节点3";
            treeNode4.Text = "系数4";
            this.Coefficient.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.Coefficient.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Coefficient.Size = new System.Drawing.Size(185, 29);
            this.Coefficient.SymbolSize = 24;
            this.Coefficient.TabIndex = 70;
            this.Coefficient.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Coefficient.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(331, 94);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(39, 16);
            this.uiLabel3.TabIndex = 69;
            this.uiLabel3.Text = "幅宽";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Breadth
            // 
            this.Breadth.CheckBoxes = true;
            this.Breadth.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.Breadth.FillColor = System.Drawing.Color.White;
            this.Breadth.Font = new System.Drawing.Font("宋体", 12F);
            this.Breadth.Location = new System.Drawing.Point(393, 86);
            this.Breadth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Breadth.MinimumSize = new System.Drawing.Size(63, 0);
            this.Breadth.Name = "Breadth";
            this.Breadth.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Breadth.Size = new System.Drawing.Size(220, 29);
            this.Breadth.SymbolSize = 24;
            this.Breadth.TabIndex = 68;
            this.Breadth.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Breadth.Watermark = "";
            this.Breadth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Breadth_MouseClick);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(12, 94);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(55, 16);
            this.uiLabel1.TabIndex = 34;
            this.uiLabel1.Text = "容错值";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FaultTolerant
            // 
            this.FaultTolerant.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FaultTolerant.Font = new System.Drawing.Font("宋体", 12F);
            this.FaultTolerant.Location = new System.Drawing.Point(106, 86);
            this.FaultTolerant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FaultTolerant.MinimumSize = new System.Drawing.Size(1, 16);
            this.FaultTolerant.Name = "FaultTolerant";
            this.FaultTolerant.Padding = new System.Windows.Forms.Padding(5);
            this.FaultTolerant.ShowText = false;
            this.FaultTolerant.Size = new System.Drawing.Size(185, 29);
            this.FaultTolerant.TabIndex = 33;
            this.FaultTolerant.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaultTolerant.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(299, 47);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(71, 16);
            this.uiLabel4.TabIndex = 32;
            this.uiLabel4.Text = "幅宽定额";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WideRating
            // 
            this.WideRating.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WideRating.Font = new System.Drawing.Font("宋体", 12F);
            this.WideRating.Location = new System.Drawing.Point(393, 39);
            this.WideRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WideRating.MinimumSize = new System.Drawing.Size(1, 16);
            this.WideRating.Name = "WideRating";
            this.WideRating.Padding = new System.Windows.Forms.Padding(5);
            this.WideRating.ShowText = false;
            this.WideRating.Size = new System.Drawing.Size(220, 29);
            this.WideRating.TabIndex = 31;
            this.WideRating.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.WideRating.Watermark = "";
            // 
            // ToolName
            // 
            this.ToolName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ToolName.EnterAsTab = true;
            this.ToolName.Font = new System.Drawing.Font("宋体", 12F);
            this.ToolName.Location = new System.Drawing.Point(106, 39);
            this.ToolName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToolName.MinimumSize = new System.Drawing.Size(1, 16);
            this.ToolName.Name = "ToolName";
            this.ToolName.Padding = new System.Windows.Forms.Padding(5);
            this.ToolName.ShowText = false;
            this.ToolName.Size = new System.Drawing.Size(185, 29);
            this.ToolName.TabIndex = 30;
            this.ToolName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolName.Watermark = "";
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(633, 127);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "查找";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 44);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "刀具名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAdd.Location = new System.Drawing.Point(739, 127);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.Symbol = 61543;
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "增加";
            this.btnAdd.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ToolSettings
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1166, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Name = "ToolSettings";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Text = "刀具设置";
            this.Initialize += new System.EventHandler(this.ToolSettings_Initialize);
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
        private Sunny.UI.UITextBox ToolName;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox WideRating;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox FaultTolerant;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboTreeView Breadth;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboTreeView Coefficient;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboTreeView PermName;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox CreateName;
        private Sunny.UI.UITextBox CreateTime;
        private Sunny.UI.UIButton uiButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToolName_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn WideRating_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaultTolerant_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Breadth_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermName_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateName_Manager;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}