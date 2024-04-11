using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Cap.SystemSetup.AlarmSetting
{
    public partial class AlarmSetting : UIPage
    {
        List<Data> dataList = new List<Data>();
        DataTable dataTable = new DataTable("DataTable");
        public AlarmSetting()
        {
            InitializeComponent();

            for (int i = 0; i < 3610; i++)
            {
                Data data = new Data();
                data.Column1 = "告警信息" + i;
                data.Column2 =  DateTime.Now.ToString(); 
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

        private void AlarmSetting_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
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
                dataTable.Rows.Add(dataList[i].Column1, dataList[i].Column2);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string rowData = row.Cells["Column1"].Value.ToString();
            string Column2 = row.Cells["Column2"].Value.ToString();


            // 确保点击的是按钮列
            if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            {
                AlarmSettingDetail companySearchDetail = new AlarmSettingDetail(rowData);///实例化窗体
                companySearchDetail.StartPosition = FormStartPosition.CenterScreen; ///确定窗体第一次显示的位置
                companySearchDetail.ShowDialog();///显示窗体 
            }


            if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                AlarmSettingEdit commpanyEdit = new AlarmSettingEdit(rowData);///实例化窗体
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

     

        private void uiSymbolButton2_Click_1(object sender, EventArgs e)
        {

            AlarmSettingAdd frm = new AlarmSettingAdd();
            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
            }

            frm.Dispose();
        }
    }
}
