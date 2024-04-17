using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.Specifications;
using Cap.BasicSettings.WidthOfCloth;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.SupplierAndCustom.Supplier
{
    public partial class Supplier : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public Supplier()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Data data = new Data();
                data.Column1 = "供应商名称" + i;
                data.Column2 = "供应商信息" + i;
                data.Column3 = "供货情况" + i;
                data.huowudanjia = "货物单价" + i;
                data.Column4 = DateTime.Now.ToString();
                data.Column5 = "管理员";
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
            dataTable.Columns.Add("Column3");
            dataTable.Columns.Add("huowudanjia");
            dataTable.Columns.Add("Column4");
            dataTable.Columns.Add("Column5");
            uiDataGridView1.DataSource = dataTable;

            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;

            //设置分页控件总数
            uiPagination1.TotalCount = dataList.Count;

            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2, dataList[i].Column3, dataList[i].huowudanjia, dataList[i].Column4, dataList[i].Column5);
            }


        }



        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }

        public class Data
        {
            public string Column1 { get; set; }

            public string Column2 { get; set; }

            public string Column3 { get; set; }
            public string huowudanjia { get; set; }
            public string Column4 { get; set; }
            public string Column5 { get; set; }

            public override string ToString()
            {
                return Column1;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //SupplierAdd frm = new SupplierAdd();
            //frm.Render();
            //frm.ShowDialog();
            dataTable.Rows.Add(edtName.Text, uiTextBox2.Text, uiTextBox1.Text, uiTextBox3.Text, uiTextBox4.Text, uiTextBox5.Text);
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Column1 = row.Cells["SupplierName"].Value.ToString();
            string Column2 = row.Cells["FullBoxCount"].Value.ToString();
            string Column3 = row.Cells["ConsumablesCount"].Value.ToString();


            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                SupplierEdit frm = new SupplierEdit(Column1, Column2, Column3);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                SupplierEdit frm = new SupplierEdit(Column1, Column2, Column3);
                frm.Render();
                frm.ShowDialog();
                frm.Dispose();
            }

            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    ShowSuccessTip("删除成功");
                    uiDataGridView1.Rows.RemoveAt(e.RowIndex);
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
                string Column1 = row.Cells["SupplierName"].Value.ToString();
                string Column2 = row.Cells["FullBoxCount"].Value.ToString();
                string Column3 = row.Cells["ConsumablesCount"].Value.ToString();
                string huowudanjia = row.Cells["huowudanjia"].Value.ToString();
                string CreationTime = row.Cells["CreationTime"].Value.ToString();
                string CreationName = row.Cells["CreationName"].Value.ToString();

                edtName.Text = Column1;
                uiTextBox2.Text = Column2;
                uiTextBox1.Text = Column3;
                uiTextBox3.Text = huowudanjia;
                uiTextBox4.Text = CreationTime;
                uiTextBox5.Text = CreationName;

            }





        }
    }
}
