using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.Specifications;
using Cap.BasicSettings.WidthOfCloth;
using Model;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.SupplierAndCustom.Supplier
{
    public partial class Supplier : UIPage
    {
        List<SupplierName> dataList = new List<SupplierName>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        public Supplier()
        {
            InitializeComponent();

            //for (int i = 0; i < 10; i++)
            //{
            //    Data data = new Data();
            //    data.Column1 = "供应商名称" + i;
            //    data.Column2 = "供应商信息" + i;
            //    data.Column3 = "供货情况" + i;
            //    data.huowudanjia = "货物单价" + i;
            //    data.Column4 = DateTime.Now.ToString();
            //    data.Column5 = "管理员";
            //    dataList.Add(data);
            //}
            ////不自动生成列
            //uiDataGridView1.AutoGenerateColumns = false;
            ////设置分页控件总数
            //uiPagination1.TotalCount = dataList.Count;
            ////设置分页控件每页数量
            //uiPagination1.PageSize = 15;
            //uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;


            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("NameOfTheSupplier_Manager");
            dataTable.Columns.Add("SuppliersList_Manager");
            dataTable.Columns.Add("SupplyPosition_Manager");
            dataTable.Columns.Add("Price_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");
            uiDataGridView1.DataSource = dataTable;
            GetList();

        }


        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<SupplierName, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(NameOfTheSupplier.Text))
            {
                where = ExpressionBuilder.And(where, f => f.NameOfTheSupplier.Contains(NameOfTheSupplier.Text));
            };
            if (!string.IsNullOrEmpty(SuppliersList.Text))
            {
                where = ExpressionBuilder.And(where, f => f.SuppliersList.Contains(SuppliersList.Text));
            };
            if (!string.IsNullOrEmpty(SupplyPosition.Text))
            {
                where = ExpressionBuilder.And(where, f => f.SupplyPosition.Contains(SupplyPosition.Text));
            };

            dataList.Clear();
            List<SupplierName> suppliers = capProjectDb.SupplierName.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in suppliers)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = suppliers.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfTheSupplier, dataList[i].SuppliersList, dataList[i].SupplyPosition, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfTheSupplier, dataList[i].SuppliersList, dataList[i].SupplyPosition, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }


        private void Supplier_Initialize(object sender, EventArgs e)
        {

            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SupplierAdd frm = new SupplierAdd();
            //frm.Render();
            //frm.ShowDialog();
            //dataTable.Rows.Add(NameOfTheSupplier.Text, SuppliersList.Text, SupplyPosition.Text, Price.Text, CreateTime.Text, CreateName.Text);

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            SupplierName supplierName = new SupplierName();
            supplierName.Id = Guid.NewGuid().ToString();
            supplierName.NameOfTheSupplier = NameOfTheSupplier.Text;
            supplierName.SuppliersList = SuppliersList.Text;
            supplierName.SupplyPosition = SupplyPosition.Text;
            supplierName.Price = decimal.Parse(Price.Text);
            supplierName.IsDelete = 0;
            supplierName.CreateTime = DateTime.Now;
            supplierName.CreateName = CreateName.Text;
            capProjectDb.SupplierName.InsertOnSubmit(supplierName);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("添加成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
            string NameOfTheSupplier_Manager = row.Cells["NameOfTheSupplier_Manager"].Value.ToString();
            string SuppliersList_Manager = row.Cells["SuppliersList_Manager"].Value.ToString();
            string SupplyPosition_Manager = row.Cells["SupplyPosition_Manager"].Value.ToString();
            string Price_Manager = row.Cells["Price_Manager"].Value.ToString();
            string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
            string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    SupplierEdit frm = new SupplierEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}


            //// 确保点击的是按钮列
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    SupplierEdit frm = new SupplierEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}

            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    SupplierName supplierName = capProjectDb.SupplierName.Where(t => t.Id == Id).FirstOrDefault();
                    supplierName.IsDelete = 99;
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

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string NameOfTheSupplier_Manager = row.Cells["NameOfTheSupplier_Manager"].Value.ToString();
                string SuppliersList_Manager = row.Cells["SuppliersList_Manager"].Value.ToString();
                string SupplyPosition_Manager = row.Cells["SupplyPosition_Manager"].Value.ToString();
                string Price_Manager = row.Cells["Price_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                NameOfTheSupplier.Text = NameOfTheSupplier_Manager;
                SuppliersList.Text = SuppliersList_Manager;
                SupplyPosition.Text = SupplyPosition_Manager;
                Price.Text = Price_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;
            }
        }

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            NameOfTheSupplier.Text = null;
            SuppliersList.Text = null;
            SupplyPosition.Text = null;
            Price.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            SupplierName supplierName = capProjectDb.SupplierName.Where(t => t.Id == Id).FirstOrDefault();
            supplierName.NameOfTheSupplier = NameOfTheSupplier.Text;
            supplierName.SuppliersList = SuppliersList.Text;
            supplierName.SupplyPosition = SupplyPosition.Text;
            supplierName.Price = decimal.Parse(Price.Text);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            GetList();

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
    }
}
