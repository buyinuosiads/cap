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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.UserId_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiRadioButton1 = new Sunny.UI.UIRadioButton();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.Position = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.Phone = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.Account = new Sunny.UI.UITextBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.Password = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.Address = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.rbFemale = new Sunny.UI.UIRadioButton();
            this.rbMale = new Sunny.UI.UIRadioButton();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.UserName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
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
            this.UserId_Manager,
            this.Name_Manager,
            this.Account_Manager,
            this.Phone_Manager,
            this.Address_Manager,
            this.Sex_Manager,
            this.Position_Manager,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.uiDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(3, 23);
            this.uiDataGridView1.Name = "uiDataGridView1";
            this.uiDataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.uiDataGridView1.RowTemplate.Height = 23;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.Size = new System.Drawing.Size(1064, 347);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellClick);
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick_1);
            // 
            // UserId_Manager
            // 
            this.UserId_Manager.DataPropertyName = "UserId_Manager";
            this.UserId_Manager.HeaderText = "UserId";
            this.UserId_Manager.Name = "UserId_Manager";
            this.UserId_Manager.ReadOnly = true;
            this.UserId_Manager.Visible = false;
            // 
            // Name_Manager
            // 
            this.Name_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_Manager.DataPropertyName = "Name_Manager";
            this.Name_Manager.HeaderText = "姓名";
            this.Name_Manager.Name = "Name_Manager";
            this.Name_Manager.ReadOnly = true;
            // 
            // Account_Manager
            // 
            this.Account_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_Manager.DataPropertyName = "Account_Manager";
            this.Account_Manager.HeaderText = "账号";
            this.Account_Manager.Name = "Account_Manager";
            this.Account_Manager.ReadOnly = true;
            // 
            // Phone_Manager
            // 
            this.Phone_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone_Manager.DataPropertyName = "Phone_Manager";
            this.Phone_Manager.HeaderText = "电话";
            this.Phone_Manager.Name = "Phone_Manager";
            this.Phone_Manager.ReadOnly = true;
            // 
            // Address_Manager
            // 
            this.Address_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address_Manager.DataPropertyName = "Address_Manager";
            this.Address_Manager.HeaderText = "地址";
            this.Address_Manager.Name = "Address_Manager";
            this.Address_Manager.ReadOnly = true;
            // 
            // Sex_Manager
            // 
            this.Sex_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sex_Manager.DataPropertyName = "Sex_Manager";
            this.Sex_Manager.HeaderText = "性别";
            this.Sex_Manager.Name = "Sex_Manager";
            this.Sex_Manager.ReadOnly = true;
            // 
            // Position_Manager
            // 
            this.Position_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Position_Manager.DataPropertyName = "Position_Manager";
            this.Position_Manager.HeaderText = "职位";
            this.Position_Manager.Name = "Position_Manager";
            this.Position_Manager.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "删除";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.groupBox1.Location = new System.Drawing.Point(0, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 408);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // uiPagination1
            // 
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(3, 370);
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
            this.uiCheckBoxGroup1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton6);
            this.uiCheckBoxGroup1.Controls.Add(this.uiRadioButton1);
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton5);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton2);
            this.uiCheckBoxGroup1.Controls.Add(this.Position);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel5);
            this.uiCheckBoxGroup1.Controls.Add(this.Phone);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel4);
            this.uiCheckBoxGroup1.Controls.Add(this.Account);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel8);
            this.uiCheckBoxGroup1.Controls.Add(this.Password);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel7);
            this.uiCheckBoxGroup1.Controls.Add(this.Address);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel1);
            this.uiCheckBoxGroup1.Controls.Add(this.rbFemale);
            this.uiCheckBoxGroup1.Controls.Add(this.rbMale);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup1.Controls.Add(this.UserName);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton1);
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
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1041, 202);
            this.uiCheckBoxGroup1.TabIndex = 5;
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
            this.uiButton6.Location = new System.Drawing.Point(777, 140);
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
            this.uiButton6.TabIndex = 89;
            this.uiButton6.Text = "清空文本框";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
            // 
            // uiRadioButton1
            // 
            this.uiRadioButton1.Checked = true;
            this.uiRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiRadioButton1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiRadioButton1.Location = new System.Drawing.Point(705, 101);
            this.uiRadioButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButton1.Name = "uiRadioButton1";
            this.uiRadioButton1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiRadioButton1.Size = new System.Drawing.Size(82, 29);
            this.uiRadioButton1.TabIndex = 88;
            this.uiRadioButton1.Text = "全部";
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
            this.uiButton5.Location = new System.Drawing.Point(671, 140);
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
            this.uiButton5.TabIndex = 87;
            this.uiButton5.Text = "修改";
            this.uiButton5.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton5.Click += new System.EventHandler(this.uiButton5_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(459, 140);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.Symbol = 61543;
            this.uiSymbolButton2.TabIndex = 86;
            this.uiSymbolButton2.Text = "增加";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click_1);
            // 
            // Position
            // 
            this.Position.DataSource = null;
            this.Position.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.Position.DropDownWidth = 300;
            this.Position.FillColor = System.Drawing.Color.White;
            this.Position.FilterMaxCount = 50;
            this.Position.Font = new System.Drawing.Font("宋体", 12F);
            this.Position.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.Position.Items.AddRange(new object[] {
            "经理",
            "员工"});
            this.Position.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.Position.Location = new System.Drawing.Point(90, 101);
            this.Position.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Position.MinimumSize = new System.Drawing.Size(63, 0);
            this.Position.Name = "Position";
            this.Position.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Position.ShowClearButton = true;
            this.Position.Size = new System.Drawing.Size(340, 29);
            this.Position.SymbolSize = 24;
            this.Position.TabIndex = 85;
            this.Position.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Position.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(12, 108);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(39, 16);
            this.uiLabel5.TabIndex = 84;
            this.uiLabel5.Text = "职位";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Phone
            // 
            this.Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Phone.EnterAsTab = true;
            this.Phone.Font = new System.Drawing.Font("宋体", 12F);
            this.Phone.Location = new System.Drawing.Point(534, 60);
            this.Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phone.MinimumSize = new System.Drawing.Size(1, 16);
            this.Phone.Name = "Phone";
            this.Phone.Padding = new System.Windows.Forms.Padding(5);
            this.Phone.ShowText = false;
            this.Phone.Size = new System.Drawing.Size(340, 29);
            this.Phone.TabIndex = 82;
            this.Phone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Phone.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(457, 64);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(39, 16);
            this.uiLabel4.TabIndex = 83;
            this.uiLabel4.Text = "电话";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Account
            // 
            this.Account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Account.EnterAsTab = true;
            this.Account.Font = new System.Drawing.Font("宋体", 12F);
            this.Account.Location = new System.Drawing.Point(535, 13);
            this.Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Account.MinimumSize = new System.Drawing.Size(1, 16);
            this.Account.Name = "Account";
            this.Account.Padding = new System.Windows.Forms.Padding(5);
            this.Account.ShowText = false;
            this.Account.Size = new System.Drawing.Size(340, 29);
            this.Account.TabIndex = 75;
            this.Account.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Account.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(457, 19);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(39, 16);
            this.uiLabel8.TabIndex = 77;
            this.uiLabel8.Text = "账号";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password
            // 
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.EnterAsTab = true;
            this.Password.Font = new System.Drawing.Font("宋体", 12F);
            this.Password.Location = new System.Drawing.Point(90, 60);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.MinimumSize = new System.Drawing.Size(1, 16);
            this.Password.Name = "Password";
            this.Password.Padding = new System.Windows.Forms.Padding(5);
            this.Password.ShowText = false;
            this.Password.Size = new System.Drawing.Size(340, 29);
            this.Password.TabIndex = 76;
            this.Password.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Password.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(12, 66);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(39, 16);
            this.uiLabel7.TabIndex = 78;
            this.uiLabel7.Text = "密码";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("宋体", 12F);
            this.Address.Location = new System.Drawing.Point(90, 140);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address.MinimumSize = new System.Drawing.Size(1, 16);
            this.Address.Name = "Address";
            this.Address.Padding = new System.Windows.Forms.Padding(5);
            this.Address.ShowText = false;
            this.Address.Size = new System.Drawing.Size(340, 29);
            this.Address.TabIndex = 79;
            this.Address.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Address.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(11, 147);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(39, 16);
            this.uiLabel1.TabIndex = 81;
            this.uiLabel1.Text = "地址";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbFemale
            // 
            this.rbFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFemale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbFemale.Location = new System.Drawing.Point(617, 101);
            this.rbFemale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbFemale.Size = new System.Drawing.Size(82, 29);
            this.rbFemale.TabIndex = 73;
            this.rbFemale.Text = "女";
            // 
            // rbMale
            // 
            this.rbMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMale.Font = new System.Drawing.Font("宋体", 12F);
            this.rbMale.Location = new System.Drawing.Point(529, 101);
            this.rbMale.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbMale.Name = "rbMale";
            this.rbMale.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbMale.Size = new System.Drawing.Size(82, 29);
            this.rbMale.TabIndex = 72;
            this.rbMale.Text = "男";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(457, 108);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(39, 16);
            this.uiLabel3.TabIndex = 80;
            this.uiLabel3.Text = "性别";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserName
            // 
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.EnterAsTab = true;
            this.UserName.Font = new System.Drawing.Font("宋体", 12F);
            this.UserName.Location = new System.Drawing.Point(90, 13);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserName.MinimumSize = new System.Drawing.Size(1, 16);
            this.UserName.Name = "UserName";
            this.UserName.Padding = new System.Windows.Forms.Padding(5);
            this.UserName.ShowText = false;
            this.UserName.Size = new System.Drawing.Size(340, 29);
            this.UserName.TabIndex = 71;
            this.UserName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(12, 20);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(39, 16);
            this.uiLabel2.TabIndex = 74;
            this.uiLabel2.Text = "姓名";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(565, 140);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "查找";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // User
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1041, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Name = "User";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
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
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIComboBox Position;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox Phone;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox Account;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UITextBox Password;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox Address;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIRadioButton rbFemale;
        private Sunny.UI.UIRadioButton rbMale;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UITextBox UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position_Manager;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIButton uiButton6;
    }
}