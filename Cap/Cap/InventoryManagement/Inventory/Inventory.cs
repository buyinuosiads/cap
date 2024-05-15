using Cap.BasicSettings.Accessories;
using Cap.FixedAssetsParent.FixedAssets;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cap.InventoryManagement.Inventory
{
    public partial class Inventory : UIPage
    {
        List<Stocks> dataList = new List<Stocks>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public Inventory(string name)
        {
            _Name = name;
            InitializeComponent();
            //for (int i = 0; i < 10; i++)
            //{
            //    Data data = new Data();
            //    data.Column1 = "物料名称" + i;
            //    data.Column2 = "物料数量" + i;
            //    data.Column4 = DateTime.Now.ToString();
            //    data.Column5 = "管理员";
            //    dataList.Add(data);
            //}


            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("NameOfMaterial_Manager");
            dataTable.Columns.Add("QuantityOfMaterial_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");
            GetList();


        }





        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<Stocks, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(NameOfMaterial.Text))
            {
                where = ExpressionBuilder.And(where, f => f.NameOfMaterial.Contains(NameOfMaterial.Text));
            };

            dataList.Clear();
            List<Stocks> productSetups = capProjectDb.Stocks.Where(where).OrderBy(a => a.Id).ToList(); //全查询
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfMaterial, dataList[i].QuantityOfMaterial, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }



        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
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
            //未连接数据库，通过模拟数据来实现
            //一般通过ORM的分页去取数据来填充
            //pageIndex：第几页，和界面对应，从1开始，取数据可能要用pageIndex - 1
            //count：单页数据量，也就是PageSize值

            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfMaterial, dataList[i].QuantityOfMaterial, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void Inventory_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Column1 = row.Cells["MaterialName"].Value.ToString();
                string Column2 = row.Cells["MaterialCount"].Value.ToString();
                InventoryEdit frm = new InventoryEdit(Column1, Column2);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Stocks stocks = capProjectDb.Stocks.Where(t => t.Id == Id).FirstOrDefault();
                    stocks.IsDelete = 99;
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

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要添加吗？"))
            {

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Stocks stocks = new Stocks();
                stocks.Id = Guid.NewGuid().ToString();
                stocks.NameOfMaterial = NameOfMaterial.Text;
                stocks.QuantityOfMaterial = int.Parse(QuantityOfMaterial.Text);
                stocks.CreateTime = DateTime.Now;
                stocks.CreateName = _Name;
                stocks.IsDelete = 0;
                //添加数据
                capProjectDb.Stocks.InsertOnSubmit(stocks);
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

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string NameOfMaterial_Manager = row.Cells["NameOfMaterial_Manager"].Value.ToString();
                string QuantityOfMaterial_Manager = row.Cells["QuantityOfMaterial_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                NameOfMaterial.Text = NameOfMaterial_Manager;
                QuantityOfMaterial.Text = QuantityOfMaterial_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;

            }
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

        /// <summary>
        /// 清空文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            NameOfMaterial.Text = null;
            QuantityOfMaterial.Text = null;
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

            if (ShowAskDialog("确定要修改吗？"))
            {
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Stocks stocks = capProjectDb.Stocks.Where(t => t.Id == Id).FirstOrDefault();
                stocks.NameOfMaterial = NameOfMaterial.Text;
                stocks.QuantityOfMaterial = int.Parse(QuantityOfMaterial.Text);
                //保存数据
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
