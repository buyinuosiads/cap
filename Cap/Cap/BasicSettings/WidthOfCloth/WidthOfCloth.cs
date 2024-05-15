using Cap.AlarmManagementParent.AlarmManagement;
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
using System.Xml.Linq;
using static Cap.SystemSetup.Company;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.SystemSetup.WidthOfCloth
{
    public partial class WidthOfCloth : UIPage
    {
        List<Breadth> dataList = new List<Breadth>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public WidthOfCloth(string Name)
        {
            InitializeComponent();
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("BreadthName_Manager");
            dataTable.Columns.Add("WidthSize_Manager");
            dataTable.Columns.Add("WidthType_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");
            GetList();
            _Name = Name;
        }



        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<Breadth, bool>> where = s => s.Id != null && s.IsDelete == 0;

            if (!string.IsNullOrEmpty(BreadthName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.BreadthName.Contains(BreadthName.Text));
            }
            else if (!string.IsNullOrEmpty(WidthSize.Text))
            {
                where = ExpressionBuilder.And(where, f => f.WidthSize.Contains(WidthSize.Text));
            }
            else if (!string.IsNullOrEmpty(WidthType.Text))
            {
                where = ExpressionBuilder.And(where, f => f.WidthType.Contains(WidthType.Text));
            }


            dataList.Clear();


            List<Breadth> sys_Users = capProjectDb.Breadth.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in sys_Users)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = sys_Users.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;

                dataTable.Rows.Add(dataList[i].Id, dataList[i].BreadthName, dataList[i].WidthSize, dataList[i].WidthType, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].BreadthName, dataList[i].WidthSize, dataList[i].WidthType, dataList[i].CreateTime, dataList[i].CreateName);
            }


        }

        private void WidthOfCloth_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 15;
        }
        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
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
                if (string.IsNullOrEmpty(BreadthName.Text))
                {
                    ShowWarningDialog("幅宽名称不能为空");
                    return;
                }
                else if (string.IsNullOrEmpty(WidthSize.Text))
                {
                    ShowWarningDialog("幅宽大小不能为空");
                    return;
                }
                else if (string.IsNullOrEmpty(WidthType.Text))
                {
                    ShowWarningDialog("幅宽类型不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Breadth breadth = new Breadth();
                breadth.Id = Guid.NewGuid().ToString();
                breadth.BreadthName = BreadthName.Text;
                breadth.WidthSize = WidthSize.Text;
                breadth.WidthType = WidthType.Text;
                breadth.CreateTime = DateTime.Now;
                breadth.CreateName = _Name;
                breadth.IsDelete = 0;
                capProjectDb.Breadth.InsertOnSubmit(breadth);
                capProjectDb.SubmitChanges();
                uiButton6_Click(sender, e); //调用清空文本框方法
                ShowSuccessDialog("添加成功");
                GetList();

            }
            else
            {
                ShowErrorTip("取消当前操作");
            }

        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 确保点击的不是表头
            if (e.RowIndex >= 0)
            {
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据 
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string BreadthName_Manager = row.Cells["BreadthName_Manager"].Value.ToString();
                string WidthSize_Manager = row.Cells["WidthSize_Manager"].Value.ToString();
                string WidthType_Manager = row.Cells["WidthType_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    WidthOfClothEdit frm = new WidthOfClothEdit(Column1, Column2);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}
                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    WidthOfClothEdit frm = new WidthOfClothEdit(Column1, Column2);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {

                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        Breadth alarm_Setting = capProjectDb.Breadth.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        alarm_Setting.IsDelete = 99;
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




        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
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
                string BreadthName_Manager = row.Cells["BreadthName_Manager"].Value.ToString();
                string WidthSize_Manager = row.Cells["WidthSize_Manager"].Value.ToString();
                string WidthType_Manager = row.Cells["WidthType_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                BreadthName.Text = BreadthName_Manager;
                WidthSize.Text = WidthSize_Manager;
                WidthType.Text = WidthType_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;

            }
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            Id = null;
            BreadthName.Text = null;
            WidthSize.Text = null;
            WidthType.Text = null;
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
                if (string.IsNullOrEmpty(BreadthName.Text))
                {
                    ShowWarningDialog("幅宽名称不能为空");
                    return;
                }
                else if (string.IsNullOrEmpty(WidthSize.Text))
                {
                    ShowWarningDialog("幅宽大小不能为空");
                    return;
                }
                else if (string.IsNullOrEmpty(WidthType.Text))
                {
                    ShowWarningDialog("幅宽类型不能为空");
                    return;
                }
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                Breadth breadth = capProjectDb.Breadth.Where(t => t.Id == Id).FirstOrDefault();
                breadth.BreadthName = BreadthName.Text;
                breadth.WidthSize = WidthSize.Text;
                breadth.WidthType = WidthType.Text;
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




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void uiCheckBoxGroup1_ValueChanged(object sender, CheckBoxGroupEventArgs e)
        {

        }
        private void uiPagination1_Click(object sender, EventArgs e)
        {

        }

    }
}
