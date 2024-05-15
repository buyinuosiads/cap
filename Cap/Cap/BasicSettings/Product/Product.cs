using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.ToolSettings;
using Model;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.BasicSettings.Product
{
    public partial class Product : UIPage
    {
        List<ProductSetup> dataList = new List<ProductSetup>();
        List<ProcessSetting> processSettings = new List<ProcessSetting>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = null;
        string _Name = string.Empty;
        public Product(string name)
        {


            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //    Data data = new Data();
            //    data.Column1 = "产品名称" + i;
            //    data.Column2 = "工艺名称" + i;
            //    data.Column3 = i.Mod(2) == 0 ? "100" : "200";
            //    data.Column4 = DateTime.Now.ToString();
            //    data.Column5 = "管理员";
            //    dataList.Add(data);
            //}

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            processSettings = capProjectDb.ProcessSetting.Where(t => t.IsDelete == 0).ToList();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("ProductName_Manager");
            dataTable.Columns.Add("ProcessName_Manager");
            dataTable.Columns.Add("Price_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");



            DataTable dt = new DataTable();
            dt.Columns.Add("Column1", typeof(string));
            dt.Columns.Add("Column2", typeof(string));

            foreach (var item in processSettings)
            {
                dt.Rows.Add(item.ProcessName, item.Price);
            }

            //for (int i = 0; i < 100; i++)
            //{
            //    dt.Rows.Add("工艺名称" + i, 100 + i);
            //}
            ProcessName.DataGridView.Init();
            ProcessName.DataGridView.MultiSelect = true;//设置可多选
            ProcessName.ItemSize = new System.Drawing.Size(360, 240);
            ProcessName.DataGridView.AddColumn("工艺名称", "Column1");
            ProcessName.DataGridView.AddColumn("工艺价格", "Column2");
            ProcessName.DataGridView.ReadOnly = false;
            ProcessName.ShowFilter = true;
            ProcessName.DataGridView.DataSource = dt;
            ProcessName.FilterColumnName = "Column1"; //不设置则全部列过滤
            // 在 DataGridView 中添加一个复选框列用于多选功能
            DataGridViewCheckBoxColumn multiSelectColumn = new DataGridViewCheckBoxColumn();
            multiSelectColumn.HeaderText = "选择";
            multiSelectColumn.Name = "MultiSelectColumn";
            ProcessName.DataGridView.Columns.Insert(0, multiSelectColumn);


            GetList();
            _Name = name;
        }


        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<ProductSetup, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(ProductName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.ProductName.Contains(ProductName.Text));
            };


            dataList.Clear();
            List<ProductSetup> productSetups = capProjectDb.ProductSetup.Where(where).OrderBy(a => a.Id).ToList(); //全查询
            foreach (var item in productSetups)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = productSetups.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProductName, dataList[i].ProcessName, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }




        /// <summary>
        /// 分页控件页面切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="pagingSource"></param>
        /// <param name="pageIndex"></param>
        /// <param name="count"></param>
        private void uiPagination1_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProductName, dataList[i].ProcessName, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];

                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string ProductName_Manager = row.Cells["ProductName_Manager"].Value.ToString();
                string ProcessName_Manager = row.Cells["ProcessName_Manager"].Value.ToString();
                string Price_Manager = row.Cells["Price_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    ProductEdit frm = new ProductEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{

                //    ProductEdit frm = new ProductEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        ProductSetup sys_User = capProjectDb.ProductSetup.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        sys_User.IsDelete = 99;
                        capProjectDb.SubmitChanges();
                        ShowSuccessTip("删除成功");
                        uiButton6_Click(sender, e); //调用清空文本框方法
                        GetList();
                    }
                    else
                    {
                        ShowErrorTip("取消当前操作");
                    }
                }
            }
        }



        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (ShowAskDialog("确定要添加吗？"))
            {

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                ProductSetup productSetup = new ProductSetup();
                productSetup.Id = Guid.NewGuid().ToString();
                productSetup.ProductName = ProductName.Text;
                productSetup.ProcessName = ProcessName.Text;
                productSetup.Price = decimal.Parse(Price.Text);
                productSetup.CreateName = _Name;
                //创建时间
                productSetup.CreateTime = DateTime.Now;
                //是否删除
                productSetup.IsDelete = 0;
                //添加数据
                capProjectDb.ProductSetup.InsertOnSubmit(productSetup);
                //保存数据
                capProjectDb.SubmitChanges();
                ShowSuccessDialog("添加成功");
                uiButton6_Click(sender, e); //调用清空文本框方法
                                            //查询数据
                GetList();

            }
            else
            {
                ShowErrorTip("取消当前操作");
            }
        }

        private void uiPagination1_Click(object sender, EventArgs e)
        {

        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Product_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                processSettings = capProjectDb.ProcessSetting.Where(t => t.IsDelete == 0).ToList();
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                Id = row.Cells["Id_Manager"].Value.ToString();
                string ProductName_Manager = row.Cells["ProductName_Manager"].Value.ToString();
                string ProcessName_Manager = row.Cells["ProcessName_Manager"].Value.ToString();
                string Price_Manager = row.Cells["Price_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                ProcessName.DataGridView.DataSource = null;
                ProcessName.DataGridView.Rows.Clear();
                ProcessName.DataGridView.Init();
                ProcessName.DataGridView.MultiSelect = true;//设置可多选
                ProcessName.ItemSize = new System.Drawing.Size(360, 240);
                ProcessName.DataGridView.ReadOnly = false;
                ProcessName.ShowFilter = true;
                ProcessName.FilterColumnName = "Column1"; //不设置则全部列过滤
                string[] ProcessName_ManagerList = ProcessName_Manager.Split(';');

                foreach (var item in processSettings)
                {
                    bool tl = false;
                    for (int i = 0; i < ProcessName_ManagerList.Length; i++)
                    {
                        if (ProcessName_ManagerList[i] == item.ProcessName)
                        {
                            ProcessName.DataGridView.Rows.Add(true, item.ProcessName, item.Price);
                            tl = true;
                            break;
                        }
                    }
                     
                    if (tl == false)
                    {
                        ProcessName.DataGridView.Rows.Add(false, item.ProcessName, item.Price);
                    } 

                }


                #region  固定的
                //for (int i = 1; i <= 20; i++)
                //{
                //    if (ProcessName_Manager == "工艺名称" + i)
                //    {
                //        ProcessName.DataGridView.Rows.Add(true, "工艺名称" + i, 100 + i);
                //    }
                //    else
                //    {
                //        ProcessName.DataGridView.Rows.Add(false, "工艺名称" + i, 100 + i);
                //    }
                //}
                #endregion

                ProductName.Text = ProductName_Manager;
                ProcessName.Text = ProcessName_Manager;
                Price.Text = Price_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;

            }
        }

        private void uiComboDataGridView2_ValueChanged(object sender, object value)
        {
            decimal Money = 0; //价格
            string txt = string.Empty;
            // 遍历 DataGridView 中的所有行
            foreach (DataGridViewRow row in ProcessName.DataGridView.Rows)
            {
                string check = string.Empty;//是否选中
                string gongyimingcheng = string.Empty; //工艺名称 
                decimal jiage = 0;
                int num = 0;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (num == 0)
                        {
                            check = cell.Value.ToString();
                        }
                        else if (num == 1)
                        {
                            gongyimingcheng = cell.Value.ToString();
                        }
                        else
                        {
                            jiage += decimal.Parse(cell.Value.ToString());
                        }
                    }
                    num++;
                }
                if (check == "True")
                {
                    txt += gongyimingcheng + ";";
                    Money += jiage;
                }
            }
            ProcessName.Text = txt;
            Price.Text = Money.ToString();
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            ProductName.Text = null;
            ProcessName.Text = null;
            Price.Text = null;
            CreateName.Text = null;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("确定要修改吗？"))
            {
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                ProductSetup productSetup = capProjectDb.ProductSetup.Where(t => t.Id == Id).FirstOrDefault();
                productSetup.ProductName = ProductName.Text;
                productSetup.ProcessName = ProcessName.Text;
                productSetup.Price = decimal.Parse(Price.Text); 
                capProjectDb.SubmitChanges();
                ShowSuccessDialog("修改成功");
                uiButton6_Click(sender, e); //调用清空文本框方法
                                            //查询数据
                GetList();

            }
            else
            {
                ShowErrorTip("取消当前操作");
            }


        }
    }
}
