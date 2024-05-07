using Cap.AttendanceManagementParent.AttendanceManagement;
using Cap.BasicSettings.ToolSettings;
using Cap.BasicSettings.WidthOfCloth;
using Cap.SystemSetup;
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

namespace Cap.BasicSettings.Ingredients
{
    public partial class Ingredients : UIPage
    {
        List<MajorIngredient> dataList = new List<MajorIngredient>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;

        public Ingredients()
        {
            InitializeComponent();
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("MainName_Manager");
            dataTable.Columns.Add("Unit_Manager");
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
            Expression<Func<MajorIngredient, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(MainName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.MainName.Contains(MainName.Text));
            };
            if (!string.IsNullOrEmpty(Unit.Text))
            {
                where = ExpressionBuilder.And(where, f => f.Unit.Contains(Unit.Text));
            };
            dataList.Clear();
            List<MajorIngredient> majorIngredients = capProjectDb.MajorIngredient.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in majorIngredients)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = majorIngredients.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].MainName, dataList[i].Unit, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].MainName, dataList[i].Unit, dataList[i].CreateTime, dataList[i].CreateName);
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

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {

                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        MajorIngredient majorIngredient = capProjectDb.MajorIngredient.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        majorIngredient.IsDelete = 99;
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
            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    IngredientsEdit frm = new IngredientsEdit(Column1, Column2);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}


            //// 确保点击的是按钮列
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{

            //    IngredientsEdit frm = new IngredientsEdit(Column1, Column2);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}


        
        }



        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            MajorIngredient majorIngredient = new MajorIngredient();
            majorIngredient.Id = Guid.NewGuid().ToString();
            majorIngredient.MainName = MainName.Text;
            majorIngredient.Unit = Unit.Text;
            majorIngredient.CreateName = CreateName.Text;
            majorIngredient.CreateTime = DateTime.Now;
            majorIngredient.IsDelete = 0;
            capProjectDb.MajorIngredient.InsertOnSubmit(majorIngredient);
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("添加成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();


        }

        private void Ingredients_Initialize(object sender, EventArgs e)
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
                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string MainName_Manager = row.Cells["MainName_Manager"].Value.ToString();
                string Unit_Manager = row.Cells["Unit_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                Id = Id_Manager;
                MainName.Text = MainName_Manager;
                Unit.Text = Unit_Manager;
                CreateName.Text = CreateName_Manager;
                CreateTime.Text = CreateTime_Manager;

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
            MainName.Text = null;
            Unit.Text = null;
            CreateName.Text = null;
            CreateTime.Text = null;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton5_Click(object sender, EventArgs e)
        {

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            MajorIngredient majorIngredient = capProjectDb.MajorIngredient.Where(t => t.Id == Id).FirstOrDefault();
            majorIngredient.MainName = MainName.Text;
            majorIngredient.Unit = Unit.Text;
            majorIngredient.CreateName = CreateName.Text;
            //保存数据
            capProjectDb.SubmitChanges();
            ShowSuccessDialog("修改成功");
            uiButton6_Click(sender, e); //调用清空文本框方法
            //查询数据
            GetList();


        }
    }
}
