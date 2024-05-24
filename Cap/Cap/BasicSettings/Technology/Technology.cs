using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.Accessories;
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
using static Cap.SystemSetup.Menu.MenuBarAdd;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cap.BasicSettings.Technology
{
    public partial class Technology : UIPage
    {
        List<ProcessSetting> dataList = new List<ProcessSetting>();
        DataTable dataTable = new DataTable("DataTable");
        string Id = null;
        string _Name = string.Empty;
        public Technology(string name)
        {
            InitializeComponent();
            _Name = name;
            //主料
            CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
            List<MajorIngredient> majorIngredients = capProjectDb.MajorIngredient.Where(t => t.IsDelete == 0).ToList();
            foreach (var item in majorIngredients)
            {
                TreeNode infoList = new TreeNode();
                infoList.Name = item.MainName;
                infoList.Text = item.MainName;
                MainIngredient.Nodes.Add(infoList);
            }


            //辅料
            List<ChargeTime> chargeTimes = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();
            foreach (var item in chargeTimes)
            {
                TreeNode infoList = new TreeNode();
                infoList.Name = item.AccessoryName;
                infoList.Text = item.AccessoryName;
                Accessory.Nodes.Add(infoList);
            }


            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("ProcessName_Manager");
            dataTable.Columns.Add("Main_Manager");
            dataTable.Columns.Add("Accessory_Manager");
            dataTable.Columns.Add("Price_Manager");
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
            Expression<Func<ProcessSetting, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(ProcessName.Text))
            {
                where = ExpressionBuilder.And(where, f => f.ProcessName.Contains(ProcessName.Text));
            };
            dataList.Clear();
            List<ProcessSetting> processSettings = capProjectDb.ProcessSetting.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in processSettings)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = processSettings.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;
            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProcessName, dataList[i].Main, dataList[i].Accessory, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
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
            dataTable.Rows.Clear();
            for (int i = (pageIndex - 1) * count; i < pageIndex * count; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].ProcessName, dataList[i].Main, dataList[i].Accessory, dataList[i].Price, dataList[i].CreateTime, dataList[i].CreateName);
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
                string ProcessName_Manager = row.Cells["ProcessName_Manager"].Value.ToString();
                string Main_Manager = row.Cells["Main_Manager"].Value.ToString();
                string Accessory_Manager = row.Cells["Accessory_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                string Price_Manager = row.Cells["Price_Manager"].Value.ToString();

                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    TechnologyEdit frm = new TechnologyEdit(Column1, zhuliao, fuliao);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    TechnologyEdit frm = new TechnologyEdit(Column1, zhuliao, fuliao);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}

                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        ProcessSetting processSetting = capProjectDb.ProcessSetting.Where(t => t.Id == Id_Manager).FirstOrDefault();
                        processSetting.IsDelete = 99;
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

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要添加吗？"))
            {

                if (string.IsNullOrEmpty(ProcessName.Text))
                {
                    ShowWarningDialog("工艺名称不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                ProcessSetting processSetting = new ProcessSetting();
                processSetting.Id = Guid.NewGuid().ToString();
                processSetting.ProcessName = ProcessName.Text;
                processSetting.Main = MainIngredient.Text;
                processSetting.Accessory = Accessory.Text;
                processSetting.Price = decimal.Parse(Price.Text);
                //创建时间
                processSetting.CreateTime = DateTime.Now;
                processSetting.CreateName = _Name;
                //添加数据
                processSetting.IsDelete = 0;
                //是否删除
                capProjectDb.ProcessSetting.InsertOnSubmit(processSetting);
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

        private void Technology_Initialize(object sender, EventArgs e)
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

                //主料
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                List<MajorIngredient> majorIngredients = capProjectDb.MajorIngredient.Where(t => t.IsDelete == 0).ToList();
                MainIngredient.Nodes.Clear();
                foreach (var item in majorIngredients)
                {
                    TreeNode infoList = new TreeNode();
                    infoList.Name = item.MainName;
                    infoList.Text = item.MainName;
                    MainIngredient.Nodes.Add(infoList);
                }


                //辅料
                List<ChargeTime> chargeTimes = capProjectDb.ChargeTime.Where(t => t.IsDelete == 0).ToList();
                Accessory.Nodes.Clear();
                foreach (var item in chargeTimes)
                {
                    TreeNode infoList = new TreeNode();
                    infoList.Name = item.AccessoryName;
                    infoList.Text = item.AccessoryName;
                    Accessory.Nodes.Add(infoList);
                }



                // 获取所点击的行
                DataGridViewRow row = uiDataGridView1.Rows[e.RowIndex];
                // 获取行数据
                string Id_Manager = row.Cells["Id_Manager"].Value.ToString();
                string ProcessName_Manager = row.Cells["ProcessName_Manager"].Value.ToString();
                string Main_Manager = row.Cells["Main_Manager"].Value.ToString();
                string Accessory_Manager = row.Cells["Accessory_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();
                string Price_Manager = row.Cells["Price_Manager"].Value.ToString();

                Id = Id_Manager;
                ProcessName.Text = ProcessName_Manager;
                CreateName.Text = CreateName_Manager;
                CreateTime.Text = CreateTime_Manager;
                Price.Text = Price_Manager;

                //主料
                if (!string.IsNullOrEmpty(Main_Manager))
                {
                    string[] role = Main_Manager.Split(';');
                    foreach (TreeNode item3 in MainIngredient.Nodes)
                    {
                        string im = item3.ToString().Replace("TreeNode: ", null);
                        for (int i = 0; i < role.Length; i++)
                        {
                            if (im == role[i].ToString().Trim())
                            {
                                item3.Checked = true;
                                break;
                            }
                            else
                            {
                                item3.Checked = false;
                            }
                        }
                    }
                }
                MainIngredient.Text = Main_Manager;


                //辅料
                if (!string.IsNullOrEmpty(Accessory_Manager))
                {
                    string[] role = Accessory_Manager.Split(';');
                    foreach (TreeNode item in Accessory.Nodes)
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
                Accessory.Text = Accessory_Manager;




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
            ProcessName.Text = null;
            MainIngredient.Text = null;
            Accessory.Text = null;
            CreateTime.Text = null;
            CreateName.Text = null;
            Price.Text = "0.00";

            foreach (TreeNode item in MainIngredient.Nodes)
            {
                item.Checked = false;
            }

            foreach (TreeNode item in Accessory.Nodes)
            {
                item.Checked = false;
            }

        }

        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            GetList();
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
                ProcessSetting processSetting = capProjectDb.ProcessSetting.Where(t => t.Id == Id).FirstOrDefault();
                processSetting.ProcessName = ProcessName.Text;
                processSetting.Main = MainIngredient.Text;
                processSetting.Accessory = Accessory.Text; 
                processSetting.Price = decimal.Parse(Price.Text);
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
