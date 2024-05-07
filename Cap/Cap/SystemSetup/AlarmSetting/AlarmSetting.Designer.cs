namespace Cap.SystemSetup.AlarmSetting
{
    partial class AlarmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.CreateTime = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.Message = new Sunny.UI.UITextBox();
            this.edtName = new Sunny.UI.UITextBox();
            this.Id_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WarningMessage_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processvalue_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Processvalue = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiButton6 = new Sunny.UI.UIButton();
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
            this.WarningMessage_Manager,
            this.Processvalue_Manager,
            this.CreateTime_Manager,
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
            this.uiDataGridView1.Size = new System.Drawing.Size(1064, 429);
            this.uiDataGridView1.TabIndex = 9;
            this.uiDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellClick);
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.uiDataGridView1);
            this.groupBox1.Controls.Add(this.uiPagination1);
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 490);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // uiPagination1
            // 
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(3, 452);
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
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(13, 43);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 29;
            this.uiLabel2.Text = "告警信息";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(282, 80);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "查找";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton6);
            this.uiCheckBoxGroup1.Controls.Add(this.Processvalue);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton5);
            this.uiCheckBoxGroup1.Controls.Add(this.CreateTime);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel1);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton2);
            this.uiCheckBoxGroup1.Controls.Add(this.Message);
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
            this.uiCheckBoxGroup1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiCheckBoxGroup1.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("uiCheckBoxGroup1.SelectedIndexes")));
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1116, 120);
            this.uiCheckBoxGroup1.TabIndex = 5;
            this.uiCheckBoxGroup1.Text = null;
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.uiButton5.Location = new System.Drawing.Point(520, 80);
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
            // CreateTime
            // 
            this.CreateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateTime.EnterAsTab = true;
            this.CreateTime.Font = new System.Drawing.Font("宋体", 12F);
            this.CreateTime.Location = new System.Drawing.Point(93, 86);
            this.CreateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Padding = new System.Windows.Forms.Padding(5);
            this.CreateTime.ShowText = false;
            this.CreateTime.Size = new System.Drawing.Size(172, 29);
            this.CreateTime.TabIndex = 33;
            this.CreateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTime.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(13, 92);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 16);
            this.uiLabel1.TabIndex = 32;
            this.uiLabel1.Text = "创建时间";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.ForestGreen;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(401, 80);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.Symbol = 61543;
            this.uiSymbolButton2.TabIndex = 35;
            this.uiSymbolButton2.Text = "增加";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click_1);
            // 
            // Message
            // 
            this.Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Message.EnterAsTab = true;
            this.Message.Font = new System.Drawing.Font("宋体", 12F);
            this.Message.Location = new System.Drawing.Point(93, 37);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Message.MinimumSize = new System.Drawing.Size(1, 16);
            this.Message.Name = "Message";
            this.Message.Padding = new System.Windows.Forms.Padding(5);
            this.Message.ShowText = false;
            this.Message.Size = new System.Drawing.Size(172, 29);
            this.Message.TabIndex = 31;
            this.Message.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Message.Watermark = "";
            // 
            // edtName
            // 
            this.edtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtName.EnterAsTab = true;
            this.edtName.Font = new System.Drawing.Font("宋体", 12F);
            this.edtName.Location = new System.Drawing.Point(59, 37);
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
            // Id_Manager
            // 
            this.Id_Manager.DataPropertyName = "Id_Manager";
            this.Id_Manager.HeaderText = "Id_Manager";
            this.Id_Manager.Name = "Id_Manager";
            this.Id_Manager.ReadOnly = true;
            this.Id_Manager.Visible = false;
            // 
            // WarningMessage_Manager
            // 
            this.WarningMessage_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WarningMessage_Manager.DataPropertyName = "WarningMessage_Manager";
            this.WarningMessage_Manager.HeaderText = "告警信息";
            this.WarningMessage_Manager.Name = "WarningMessage_Manager";
            this.WarningMessage_Manager.ReadOnly = true;
            // 
            // Processvalue_Manager
            // 
            this.Processvalue_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Processvalue_Manager.DataPropertyName = "Processvalue_Manager";
            this.Processvalue_Manager.HeaderText = "工艺乏值时间(秒)";
            this.Processvalue_Manager.Name = "Processvalue_Manager";
            this.Processvalue_Manager.ReadOnly = true;
            // 
            // CreateTime_Manager
            // 
            this.CreateTime_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime_Manager.DataPropertyName = "CreateTime_Manager";
            this.CreateTime_Manager.HeaderText = "创建时间";
            this.CreateTime_Manager.Name = "CreateTime_Manager";
            this.CreateTime_Manager.ReadOnly = true;
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
            this.Search.Visible = false;
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
            this.Edit.Visible = false;
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
            // Processvalue
            // 
            this.Processvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Processvalue.EnterAsTab = true;
            this.Processvalue.Font = new System.Drawing.Font("宋体", 12F);
            this.Processvalue.Location = new System.Drawing.Point(430, 37);
            this.Processvalue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Processvalue.MinimumSize = new System.Drawing.Size(1, 16);
            this.Processvalue.Name = "Processvalue";
            this.Processvalue.Padding = new System.Windows.Forms.Padding(5);
            this.Processvalue.ShowText = false;
            this.Processvalue.Size = new System.Drawing.Size(172, 29);
            this.Processvalue.TabIndex = 90;
            this.Processvalue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Processvalue.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(288, 43);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(135, 16);
            this.uiLabel3.TabIndex = 89;
            this.uiLabel3.Text = "工艺乏值时间(秒)";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiButton6.Location = new System.Drawing.Point(639, 80);
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
            // AlarmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 693);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Name = "AlarmSetting";
            this.Text = "告警设置";
            this.Initialize += new System.EventHandler(this.AlarmSetting_Initialize);
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
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UITextBox edtName;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UITextBox CreateTime;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UITextBox Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn WarningMessage_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processvalue_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime_Manager;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Sunny.UI.UITextBox Processvalue;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIButton uiButton6;
    }
}