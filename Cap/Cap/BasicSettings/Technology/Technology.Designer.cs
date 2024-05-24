namespace Cap.BasicSettings.Technology
{
    partial class Technology
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Technology));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.btnAdd = new Sunny.UI.UISymbolButton();
            this.uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            this.Price = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiButton5 = new Sunny.UI.UIButton();
            this.CreateName = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.CreateTime = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.Accessory = new Sunny.UI.UIComboTreeView();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.MainIngredient = new Sunny.UI.UIComboTreeView();
            this.ProcessName = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.Id_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcessName_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accessory_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateName_Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uiCheckBoxGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(15, 125);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Symbol = 61442;
            this.uiSymbolButton1.TabIndex = 3;
            this.uiSymbolButton1.Text = "查找";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FillColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("宋体", 12F);
            this.btnAdd.Location = new System.Drawing.Point(121, 125);
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
            // uiCheckBoxGroup1
            // 
            this.uiCheckBoxGroup1.Controls.Add(this.Price);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel4);
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton6);
            this.uiCheckBoxGroup1.Controls.Add(this.uiButton5);
            this.uiCheckBoxGroup1.Controls.Add(this.CreateName);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel3);
            this.uiCheckBoxGroup1.Controls.Add(this.CreateTime);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel1);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel6);
            this.uiCheckBoxGroup1.Controls.Add(this.Accessory);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel5);
            this.uiCheckBoxGroup1.Controls.Add(this.MainIngredient);
            this.uiCheckBoxGroup1.Controls.Add(this.ProcessName);
            this.uiCheckBoxGroup1.Controls.Add(this.uiLabel2);
            this.uiCheckBoxGroup1.Controls.Add(this.uiSymbolButton1);
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
            this.uiCheckBoxGroup1.Size = new System.Drawing.Size(1316, 174);
            this.uiCheckBoxGroup1.TabIndex = 11;
            this.uiCheckBoxGroup1.Text = null;
            this.uiCheckBoxGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price
            // 
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.EnterAsTab = true;
            this.Price.Font = new System.Drawing.Font("宋体", 12F);
            this.Price.Location = new System.Drawing.Point(493, 46);
            this.Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Price.MinimumSize = new System.Drawing.Size(1, 16);
            this.Price.Name = "Price";
            this.Price.Padding = new System.Windows.Forms.Padding(5);
            this.Price.ShowText = false;
            this.Price.Size = new System.Drawing.Size(294, 29);
            this.Price.TabIndex = 91;
            this.Price.Text = "0.00";
            this.Price.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Price.Type = Sunny.UI.UITextBox.UIEditType.Double;
            this.Price.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(432, 54);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(39, 16);
            this.uiLabel4.TabIndex = 92;
            this.uiLabel4.Text = "价格";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.uiButton6.Location = new System.Drawing.Point(342, 125);
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
            this.uiButton6.TabIndex = 90;
            this.uiButton6.Text = "清空文本框";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.Click += new System.EventHandler(this.uiButton6_Click);
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
            this.uiButton5.Location = new System.Drawing.Point(227, 125);
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
            // CreateName
            // 
            this.CreateName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateName.EnterAsTab = true;
            this.CreateName.Font = new System.Drawing.Font("宋体", 12F);
            this.CreateName.Location = new System.Drawing.Point(493, 85);
            this.CreateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateName.MinimumSize = new System.Drawing.Size(1, 16);
            this.CreateName.Name = "CreateName";
            this.CreateName.Padding = new System.Windows.Forms.Padding(5);
            this.CreateName.ShowText = false;
            this.CreateName.Size = new System.Drawing.Size(294, 29);
            this.CreateName.TabIndex = 43;
            this.CreateName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateName.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(429, 93);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(55, 16);
            this.uiLabel3.TabIndex = 44;
            this.uiLabel3.Text = "创建人";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreateTime
            // 
            this.CreateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CreateTime.EnterAsTab = true;
            this.CreateTime.Font = new System.Drawing.Font("宋体", 12F);
            this.CreateTime.Location = new System.Drawing.Point(103, 85);
            this.CreateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CreateTime.MinimumSize = new System.Drawing.Size(1, 16);
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Padding = new System.Windows.Forms.Padding(5);
            this.CreateTime.ShowText = false;
            this.CreateTime.Size = new System.Drawing.Size(294, 29);
            this.CreateTime.TabIndex = 41;
            this.CreateTime.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateTime.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(9, 93);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(71, 16);
            this.uiLabel1.TabIndex = 42;
            this.uiLabel1.Text = "创建时间";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(9, 54);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(39, 16);
            this.uiLabel6.TabIndex = 81;
            this.uiLabel6.Text = "辅料";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Accessory
            // 
            this.Accessory.CheckBoxes = true;
            this.Accessory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.Accessory.FillColor = System.Drawing.Color.White;
            this.Accessory.Font = new System.Drawing.Font("宋体", 12F);
            this.Accessory.Location = new System.Drawing.Point(103, 46);
            this.Accessory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Accessory.MinimumSize = new System.Drawing.Size(63, 0);
            this.Accessory.Name = "Accessory";
            this.Accessory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.Accessory.Size = new System.Drawing.Size(294, 29);
            this.Accessory.SymbolSize = 24;
            this.Accessory.TabIndex = 80;
            this.Accessory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accessory.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(432, 15);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(39, 16);
            this.uiLabel5.TabIndex = 79;
            this.uiLabel5.Text = "主料";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainIngredient
            // 
            this.MainIngredient.CheckBoxes = true;
            this.MainIngredient.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.MainIngredient.FillColor = System.Drawing.Color.White;
            this.MainIngredient.Font = new System.Drawing.Font("宋体", 12F);
            this.MainIngredient.Location = new System.Drawing.Point(493, 7);
            this.MainIngredient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainIngredient.MinimumSize = new System.Drawing.Size(63, 0);
            this.MainIngredient.Name = "MainIngredient";
            this.MainIngredient.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.MainIngredient.Size = new System.Drawing.Size(294, 29);
            this.MainIngredient.SymbolSize = 24;
            this.MainIngredient.TabIndex = 78;
            this.MainIngredient.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainIngredient.Watermark = "";
            // 
            // ProcessName
            // 
            this.ProcessName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProcessName.EnterAsTab = true;
            this.ProcessName.Font = new System.Drawing.Font("宋体", 12F);
            this.ProcessName.Location = new System.Drawing.Point(103, 7);
            this.ProcessName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProcessName.MinimumSize = new System.Drawing.Size(1, 16);
            this.ProcessName.Name = "ProcessName";
            this.ProcessName.Padding = new System.Windows.Forms.Padding(5);
            this.ProcessName.ShowText = false;
            this.ProcessName.Size = new System.Drawing.Size(294, 29);
            this.ProcessName.TabIndex = 39;
            this.ProcessName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProcessName.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("宋体", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(9, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(71, 16);
            this.uiLabel2.TabIndex = 40;
            this.uiLabel2.Text = "工艺名称";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiPagination1
            // 
            this.uiPagination1.CausesValidation = false;
            this.uiPagination1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F);
            this.uiPagination1.Location = new System.Drawing.Point(3, 398);
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.uiDataGridView1);
            this.groupBox1.Controls.Add(this.uiPagination1);
            this.groupBox1.Location = new System.Drawing.Point(0, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 436);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
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
            this.ProcessName_Manager,
            this.Main_Manager,
            this.Accessory_Manager,
            this.Price_Manager,
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
            this.uiDataGridView1.Size = new System.Drawing.Size(1064, 375);
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
            // ProcessName_Manager
            // 
            this.ProcessName_Manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcessName_Manager.DataPropertyName = "ProcessName_Manager";
            this.ProcessName_Manager.HeaderText = "工艺名称";
            this.ProcessName_Manager.Name = "ProcessName_Manager";
            this.ProcessName_Manager.ReadOnly = true;
            // 
            // Main_Manager
            // 
            this.Main_Manager.DataPropertyName = "Main_Manager";
            this.Main_Manager.HeaderText = "主料";
            this.Main_Manager.Name = "Main_Manager";
            this.Main_Manager.ReadOnly = true;
            // 
            // Accessory_Manager
            // 
            this.Accessory_Manager.DataPropertyName = "Accessory_Manager";
            this.Accessory_Manager.HeaderText = "辅料";
            this.Accessory_Manager.Name = "Accessory_Manager";
            this.Accessory_Manager.ReadOnly = true;
            // 
            // Price_Manager
            // 
            this.Price_Manager.DataPropertyName = "Price_Manager";
            this.Price_Manager.HeaderText = "工艺价格";
            this.Price_Manager.Name = "Price_Manager";
            this.Price_Manager.ReadOnly = true;
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
            // Technology
            // 
            this.AllowShowTitle = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1316, 655);
            this.Controls.Add(this.uiCheckBoxGroup1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Technology";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.ShowTitle = true;
            this.Text = "工艺设置";
            this.Initialize += new System.EventHandler(this.Technology_Initialize);
            this.uiCheckBoxGroup1.ResumeLayout(false);
            this.uiCheckBoxGroup1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton btnAdd;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Sunny.UI.UIPagination uiPagination1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboTreeView MainIngredient;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboTreeView Accessory;
        private Sunny.UI.UITextBox CreateName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox CreateTime;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UITextBox ProcessName;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UITextBox Price;
        private Sunny.UI.UILabel uiLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accessory_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime_Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateName_Manager;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}