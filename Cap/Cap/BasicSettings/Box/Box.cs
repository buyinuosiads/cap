using Cap.AttendanceManagementParent.AttendanceManagement;
using Cap.BasicSettings.Product;
using Cap.SystemSetup.Role;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.BasicSettings.Box
{
    public partial class Box : UIPage
    {
        List<BoxGaugeSetting> dataList = new List<BoxGaugeSetting>();
        DataTable dataTable = new DataTable("DataTable");

        string Id = null;
        string _Name = string.Empty;
        public Box(string name)
        {
            InitializeComponent();

            _Name = name;
            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("CaseGaugeName_Manager");
            dataTable.Columns.Add("ContainerLoad_Manager");
            dataTable.Columns.Add("ConsumableNumber_Manager");
            dataTable.Columns.Add("AccessoryName_Manager");
            dataTable.Columns.Add("AccessoryNum_Manager");
            dataTable.Columns.Add("CreateTime_Manager");
            dataTable.Columns.Add("CreateName_Manager");


            AccessoryName.DataGridView.Init();
            AccessoryName.DataGridView.MultiSelect = true;//设置可多选
            AccessoryName.DataGridView.ReadOnly = false;
            AccessoryName.ShowFilter = true;
            // 添加多选按钮列
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "多选";
            checkBoxColumn.Name = "checkBoxColumn";
            AccessoryName.DataGridView.Columns.Insert(0, checkBoxColumn);
            // 添加其他列
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "辅料";
            column1.Name = "辅料";
            AccessoryName.DataGridView.Columns.Add(column1);
            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.HeaderText = "辅料数量";
            editableColumn.Name = "EditableColumn";
            AccessoryName.DataGridView.Columns.Add(editableColumn);

            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            List<ChargeTime> charges = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();
            foreach (var item in charges)
            {
                AccessoryName.DataGridView.Rows.Add(false, item.AccessoryName);
            }
            //for (int i = 1; i <= 20; i++)
            //{
            //    AccessoryName.DataGridView.Rows.Add(false, "辅料" + i);
            //}
            GetList();


        }



        /// <summary>
        /// 查询
        /// </summary>
        public void GetList()
        {
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            Expression<Func<BoxGaugeSetting, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(CaseGaugeName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.CaseGaugeName.Contains(CaseGaugeName.Text));
            };
            dataList.Clear();
            List<BoxGaugeSetting> boxGaugeSettings = capProjectDb.BoxGaugeSetting.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in boxGaugeSettings)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = boxGaugeSettings.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].CaseGaugeName, dataList[i].ContainerLoad, dataList[i].ConsumableNumber, dataList[i].AccessoryName, dataList[i].AccessoryNum, dataList[i].CreateTime, dataList[i].CreateName);
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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].CaseGaugeName, dataList[i].ContainerLoad, dataList[i].ConsumableNumber, dataList[i].AccessoryName, dataList[i].AccessoryNum, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }


        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //// 获取所点击的行
            //DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
            //// 获取行数据
            //string Column1 = row.Cells["BoxName"].Value.ToString();
            //string Column2 = row.Cells["Column6"].Value.ToString();
            //string Column3 = row.Cells["ConsumablesCount"].Value.ToString();

            //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
            //{
            //    BoxEdit frm = new BoxEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}

            //// 确保点击的是按钮列
            //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            //{

            //    BoxEdit frm = new BoxEdit(Column1, Column2, Column3);
            //    frm.Render();
            //    frm.ShowDialog();
            //    frm.Dispose();
            //}

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


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ShowAskDialog("确定要添加吗？"))
            {

                if (string.IsNullOrEmpty(CaseGaugeName.Text))
                {
                    ShowWarningDialog("箱规名称不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(ContainerLoad.Text))
                {
                    ShowWarningDialog("满箱数不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(ConsumableNumber.Text))
                {
                    ShowWarningDialog("耗材不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(AccessoryName.Text))
                {
                    ShowWarningDialog("辅料不能为空");
                    return;
                }


                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                BoxGaugeSetting boxGaugeSetting = new BoxGaugeSetting();
                boxGaugeSetting.Id = Guid.NewGuid().ToString();
                boxGaugeSetting.CaseGaugeName = CaseGaugeName.Text;
                boxGaugeSetting.ContainerLoad = ContainerLoad.Text;
                boxGaugeSetting.ConsumableNumber = ConsumableNumber.Text;
                boxGaugeSetting.AccessoryName = AccessoryName.Text;
                boxGaugeSetting.AccessoryNum = AccessoryNum.Text;
                boxGaugeSetting.CreateTime = DateTime.Now;
                boxGaugeSetting.CreateName = _Name;
                boxGaugeSetting.IsDelete = 0;
                //添加数据
                capProjectDb.BoxGaugeSetting.InsertOnSubmit(boxGaugeSetting);
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

        private void Box_Initialize(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;
            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
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
                string CaseGaugeName_Manager = row.Cells["CaseGaugeName_Manager"].Value.ToString();
                string ContainerLoad_Manager = row.Cells["ContainerLoad_Manager"].Value.ToString();
                string ConsumableNumber_Manager = row.Cells["ConsumableNumber_Manager"].Value.ToString();
                string AccessoryName_Manager = row.Cells["AccessoryName_Manager"].Value.ToString();
                string AccessoryNum_Manager = row.Cells["AccessoryNum_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();

                Id = Id_Manager;
                CaseGaugeName.Text = CaseGaugeName_Manager;
                AccessoryName.Text = AccessoryName_Manager;
                ContainerLoad.Text = ContainerLoad_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;
                AccessoryNum.Text = AccessoryNum_Manager;

                //耗材
                if (!string.IsNullOrEmpty(ConsumableNumber_Manager))
                {
                    string[] role = ConsumableNumber_Manager.Split(';');
                    foreach (TreeNode item in ConsumableNumber.Nodes)
                    {
                        string im = item.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString().Trim())
                            {
                                item.Checked = true;
                                break;
                            }
                            else
                            {
                                item.Checked = false;
                            }
                        }
                    }
                }
                ConsumableNumber.Text = ConsumableNumber_Manager;
                AccessoryName.DataGridView.Rows.Clear();
                AccessoryName.DataGridView.DataSource = null;

                //辅料
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                List<ChargeTime> charges = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();

                string[] AccessoryName_ = AccessoryName_Manager.Split(';');
                string[] AccessoryNum_ = AccessoryNum_Manager.Split(';');

                foreach (var item in charges)
                {
                    bool tl = false;
                    for (int i = 0; i < AccessoryName_.Length; i++)
                    {
                        if (AccessoryName_[i].ToString().Trim() == item.AccessoryName)
                        {
                            AccessoryName.DataGridView.Rows.Add(true, item.AccessoryName, AccessoryNum_[i].ToString());
                            tl = true;
                            break;
                        }
                    }
                    if (tl == false)
                    {
                        AccessoryName.DataGridView.Rows.Add(false, item.AccessoryName);
                    }
                }

                //for (int i = 1; i <= 20; i++)
                //{
                //    if (AccessoryName_Manager == "辅料" + i)
                //    {
                //        AccessoryName.DataGridView.Rows.Add(true, "辅料" + i);
                //    }
                //    else
                //    {
                //        AccessoryName.DataGridView.Rows.Add(false, "辅料" + i);
                //    }
                //}
            }
        }

        private void uiComboDataGridView2_ValueChanged(object sender, object value)
        {
            string txt = string.Empty;
            string txtsum = string.Empty;
            // 遍历 DataGridView 中的所有行
            foreach (DataGridViewRow row in AccessoryName.DataGridView.Rows)
            {
                string check = string.Empty;//是否选中
                string gongyimingcheng = string.Empty; //辅料名称 
                int shuliang = 0;  //辅料数量
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
                            shuliang += int.Parse(cell.Value.ToString());
                        }
                    }
                    num++;
                }
                if (check == "True")
                {
                    txt += gongyimingcheng + ";";
                    txtsum += shuliang + ";";
                }
            }
            AccessoryName.Text = txt;
            AccessoryNum.Text = txtsum;
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

            //辅料
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            List<ChargeTime> charges = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();
            AccessoryName.DataGridView.Rows.Clear();
            foreach (var item in charges)
            {
                AccessoryName.DataGridView.Rows.Add(false, item.AccessoryName);
            }

            //耗材
            foreach (TreeNode item in ConsumableNumber.Nodes)
            {
                item.Checked = false;
            }
            CaseGaugeName.Text = null;
            ContainerLoad.Text = null;
            ConsumableNumber.Text = null;
            AccessoryName.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
            AccessoryNum.Text = null;


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

                if (string.IsNullOrEmpty(CaseGaugeName.Text))
                {
                    ShowWarningDialog("箱规名称不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(ContainerLoad.Text))
                {
                    ShowWarningDialog("满箱数不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(ConsumableNumber.Text))
                {
                    ShowWarningDialog("耗材不能为空");
                    return;
                }
                if (string.IsNullOrEmpty(AccessoryName.Text))
                {
                    ShowWarningDialog("辅料不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                BoxGaugeSetting boxGaugeSetting = capProjectDb.BoxGaugeSetting.Where(t => t.Id == Id).FirstOrDefault();
                boxGaugeSetting.CaseGaugeName = CaseGaugeName.Text;
                boxGaugeSetting.ContainerLoad = ContainerLoad.Text;
                boxGaugeSetting.ConsumableNumber = ConsumableNumber.Text;
                boxGaugeSetting.AccessoryName = AccessoryName.Text;
                boxGaugeSetting.AccessoryNum = AccessoryNum.Text;
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

        /// <summary>
        /// 辅料列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccessoryName_MouseClick(object sender, MouseEventArgs e)
        {
            AccessoryName.DataGridView.ClearAll();
            AccessoryName.DataGridView.Init();
            AccessoryName.DataGridView.MultiSelect = true;//设置可多选
            AccessoryName.DataGridView.ReadOnly = false;
            AccessoryName.ShowFilter = true;
            // 添加多选按钮列
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "多选";
            checkBoxColumn.Name = "checkBoxColumn";
            AccessoryName.DataGridView.Columns.Insert(0, checkBoxColumn);
            // 添加其他列
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "辅料";
            column1.Name = "辅料";
            AccessoryName.DataGridView.Columns.Add(column1);
            DataGridViewTextBoxColumn editableColumn = new DataGridViewTextBoxColumn();
            editableColumn.HeaderText = "辅料数量";
            editableColumn.Name = "EditableColumn";
            AccessoryName.DataGridView.Columns.Add(editableColumn);

            //辅料
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            List<ChargeTime> charges = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();

            string[] AccessoryName_ = AccessoryName.Text.Split(';');
            string[] AccessoryNum_ = AccessoryNum.Text.Split(';');

            foreach (var item in charges)
            {
                bool tl = false;
                for (int i = 0; i < AccessoryName_.Length; i++)
                {
                    if (AccessoryName_[i].ToString().Trim() == item.AccessoryName)
                    {
                        AccessoryName.DataGridView.Rows.Add(true, item.AccessoryName, AccessoryNum_[i].ToString());
                        tl = true;
                        break;
                    }
                }
                if (tl == false)
                {
                    AccessoryName.DataGridView.Rows.Add(false, item.AccessoryName);
                }
            }
        }
    }
}