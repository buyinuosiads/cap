using Cap.BasicSettings.Accessories;
using Cap.Order.OrderSplitting;
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

namespace Cap.FixedAssetsParent.FixedAssets
{
    public partial class FixedAssets : UIPage
    {
        List<Cap_FixedAssets> dataList = new List<Cap_FixedAssets>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = string.Empty;
        string _Name = string.Empty;
        public FixedAssets(string name)
        {
            InitializeComponent();
            AcquisitionDate.Text = DateTime.Now.ToString();
            AcquisitionDate.Value = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("AssetNumber_Manager");
            dataTable.Columns.Add("AssetName_Manager");
            dataTable.Columns.Add("AcquisitionDate_Manager");
            dataTable.Columns.Add("PurchaseAmount_Manager");
            dataTable.Columns.Add("AssetsClass_Manager");
            dataTable.Columns.Add("AssetStatus_Manager");
            dataTable.Columns.Add("Remark_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");

            GetList();
            _Name = name;
        }


        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<Cap_FixedAssets, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(AssetNumber.Text))
            {
                where = ExpressionBuilder.And(where, f => f.AssetNumber.Contains(AssetNumber.Text));
            };

            dataList.Clear();
            List<Cap_FixedAssets> cap_FixedAssets = capProjectDb.Cap_FixedAssets.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in cap_FixedAssets)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = cap_FixedAssets.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AssetNumber, dataList[i].AssetName, dataList[i].AcquisitionDate?.ToString("yyyy-MM-dd HH:mm:ss"), dataList[i].PurchaseAmount, dataList[i].AssetsClass, dataList[i].AssetStatus, dataList[i].Remark, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }

        private void FixedAssets_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].AssetNumber, dataList[i].AssetName, dataList[i].AcquisitionDate, dataList[i].PurchaseAmount, dataList[i].AssetsClass, dataList[i].AssetStatus, dataList[i].Remark, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }

        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // 获取所点击的行
            DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            // 获取行数据
            string Id_Manager = row.Cells["Id_Manager"].Value.ToString();


            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    FixedAssetsEdit order = new FixedAssetsEdit(rowData, Column2, Column3, Column4, Column5, Column6, Column7);///实例化窗体
            //    order.ShowDialog();
            //}
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{
            //    FixedAssetsEdit order = new FixedAssetsEdit(rowData, Column2, Column3, Column4, Column5, Column6, Column7);///实例化窗体
            //    order.ShowDialog();
            //}


            if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (ShowAskDialog("确定要删除吗？"))
                {
                    //ShowSuccessTip("删除成功");
                    //uiDataGridView1.Rows.RemoveAt(e.RowIndex);

                    CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                    Cap_FixedAssets cap_Fixed = capProjectDb.Cap_FixedAssets.Where(t => t.Id == Id).FirstOrDefault();
                    cap_Fixed.IsDelete = 0;
                    capProjectDb.SubmitChanges();
                    ShowSuccessTip("删除成功");
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
                Cap_FixedAssets cap_Fixed = new Cap_FixedAssets();
                cap_Fixed.Id = Guid.NewGuid().ToString();
                cap_Fixed.AssetNumber = AssetNumber.Text;
                cap_Fixed.AssetName = AssetName.Text;
                cap_Fixed.AcquisitionDate = DateTime.Parse(AcquisitionDate.Text);
                cap_Fixed.PurchaseAmount = decimal.Parse(PurchaseAmount.Text);
                cap_Fixed.AssetsClass = AssetsClass.Text;
                cap_Fixed.AssetStatus = AssetStatus.Text;
                cap_Fixed.Remark = Remark.Text;
                cap_Fixed.CreateTime = DateTime.Now;
                cap_Fixed.CreateName = _Name;
                cap_Fixed.IsDelete = 0;
                //添加数据
                capProjectDb.Cap_FixedAssets.InsertOnSubmit(cap_Fixed);
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
                string AssetNumber_Manager = row.Cells["AssetNumber_Manager"].Value.ToString();
                string AssetName_Manager = row.Cells["AssetName_Manager"].Value.ToString();
                string AcquisitionDate_Manager = row.Cells["AcquisitionDate_Manager"].Value.ToString();
                string PurchaseAmount_Manager = row.Cells["PurchaseAmount_Manager"].Value.ToString();
                string AssetsClass_Manager = row.Cells["AssetsClass_Manager"].Value.ToString();
                string AssetStatus_Manager = row.Cells["AssetStatus_Manager"].Value.ToString();
                string Remark_Manager = row.Cells["Remark_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                AssetNumber.Text = AssetNumber_Manager;
                AssetName.Text = AssetName_Manager;
                AcquisitionDate.Text = AcquisitionDate_Manager;
                PurchaseAmount.Text = PurchaseAmount_Manager;
                AssetsClass.Text = AssetsClass_Manager;
                AssetStatus.Text = AssetStatus_Manager;
                Remark.Text = Remark_Manager;
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
            AssetNumber.Text = null;
            AssetName.Text = null;
            AcquisitionDate.Text = null;
            PurchaseAmount.Text = null;
            AssetsClass.Text = null;
            AssetStatus.Text = null;
            Remark.Text = null;
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
                Cap_FixedAssets cap_Fixed = capProjectDb.Cap_FixedAssets.Where(t => t.Id == Id).FirstOrDefault();
                cap_Fixed.AssetNumber = AssetNumber.Text;
                cap_Fixed.AssetName = AssetName.Text;
                //cap_Fixed.AcquisitionDate =  ;
                cap_Fixed.PurchaseAmount = decimal.Parse(PurchaseAmount.Text);
                cap_Fixed.AssetsClass = AssetsClass.Text;
                cap_Fixed.AssetStatus = AssetStatus.Text;
                cap_Fixed.Remark = Remark.Text; 
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
