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
        public Company()
        {
            InitializeComponent();

            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.Column1 = "大力" + i;
                data.Column2 = i.Mod(2) == 0 ? "A" : "B";
                data.Column3 = "编辑";
                data.Column4 = i.Mod(4) == 0;
                dataList.Add(data);
            }

            dataTable.Columns.Add("Column1");
            dataTable.Columns.Add("Column2");
            dataTable.Columns.Add("Column3");
            dataTable.Columns.Add("Column4");
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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2, dataList[i].Column3, dataList[i].Column4);
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

            public override string ToString()
            {
                return Column1;
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Company_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompanyAdd frm = new CompanyAdd();
            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
                ShowSuccessDialog(frm.Person.ToString());
            }

            frm.Dispose();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void uiPagination1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {

        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
