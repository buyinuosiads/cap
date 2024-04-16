using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.SystemSetup
{
    public partial class Company : UIPage
    {

        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        //CapProjectDataContext capProjectDb = new CapProjectDataContext();

        public Company()
        {
            InitializeComponent();

            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.Column1 = "大力公司" + i;
                data.Column2 = DateTime.Now.ToString();

                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
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

            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2);
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

            public bool Column4 { get; set; }


        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string rowData = row.Cells["Column1"].Value.ToString();
            string Column2 = row.Cells["Column2"].Value.ToString();


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                CompanyDetail companySearchDetail = new CompanyDetail(rowData);///实例化窗体
                companySearchDetail.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                companySearchDetail.ShowDialog();///显示窗体 
            }


            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                CommpanyEdit commpanyEdit = new CommpanyEdit(rowData);///实例化窗体
                commpanyEdit.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                commpanyEdit.ShowDialog();///显示窗体 
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

        private void Company_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;

        }


        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {

            Data data = new Data();
            data.Column1 = edtName.Text;
            data.Column2 = DateTime.Now.ToString();
            dataTable.Rows.Add(data.Column1, data.Column2);
         

            //CompanyAdd frm = new CompanyAdd();
            //frm.Render();
            //frm.ShowDialog();
            //if (frm.IsOK)
            //{
            //}
            //frm.Dispose();



        }

        private void uiDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string rowData = row.Cells["Column1"].Value.ToString();
                string Column2 = row.Cells["Column2"].Value.ToString();

                edtName.Text = rowData;
            }
        }
    }
}
