﻿using Cap.AlarmManagementParent.AlarmManagement;
using Cap.BasicSettings.Accessories;
using Cap.BasicSettings.Product;
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

namespace Cap.BasicSettings.Specifications
{
    public partial class Specifications : UIPage
    {
        string Id = string.Empty;
        List<SpecificationSetting> dataList = new List<SpecificationSetting>();
        DataTable dataTable = new DataTable("DataTable");
        string _Name = string.Empty;
        public Specifications(string name)
        {
            InitializeComponent();

            dataTable.Columns.Add("Id_Manager");
            dataTable.Columns.Add("NameOfTheMaterial_Manager");
            dataTable.Columns.Add("Unit_Manager");
            dataTable.Columns.Add("LengthUnit_Manager");
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
            Expression<Func<SpecificationSetting, bool>> where = s => s.Id != null && s.IsDelete == 0;
            if (!string.IsNullOrEmpty(NameOfTheMaterial.Text))
            {
                where = ExpressionBuilder.And(where, f => f.NameOfTheMaterial.Contains(NameOfTheMaterial.Text));
            };

            dataList.Clear();
            List<SpecificationSetting> specificationSettings = capProjectDb.SpecificationSetting.Where(where).OrderByDescending(t => t.CreateTime).ToList(); //全查询
            foreach (var item in specificationSettings)
            {
                dataList.Add(item);
            }
            uiDataGridView1.DataSource = dataTable;
            //不自动生成列
            uiDataGridView1.AutoGenerateColumns = false;
            //设置分页控件总数
            uiPagination1.TotalCount = specificationSettings.Count;
            //设置分页控件每页数量
            uiPagination1.PageSize = 15;
            uiDataGridView1.SelectIndexChange += uiDataGridView1_SelectIndexChange;

            dataTable.Rows.Clear();
            for (int i = (1 - 1) * 15; i < 1 * 15; i++)
            {
                if (i >= dataList.Count) break;
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfTheMaterial, dataList[i].Unit, dataList[i].LengthUnit, dataList[i].CreateTime, dataList[i].CreateName);

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
                dataTable.Rows.Add(dataList[i].Id, dataList[i].NameOfTheMaterial, dataList[i].Unit, dataList[i].LengthUnit, dataList[i].CreateTime, dataList[i].CreateName);
            }
        }

        private void uiDataGridView1_SelectIndexChange(object sender, int index)
        {
            index.WriteConsole("SelectedIndex");
        }


        private void Specifications_Initialize_1(object sender, EventArgs e)
        {
            // 获取 uiCheckBoxGroup1 的宽度
            int checkBoxGroupWidth = uiCheckBoxGroup1.Width;
            int checkBoxGroupHeigth = uiCheckBoxGroup1.Height;

            // 将 groupBox1 的宽度设置为与 uiCheckBoxGroup1 相同
            groupBox1.Width = checkBoxGroupWidth;
            groupBox1.Height = this.Height - checkBoxGroupHeigth - 65;
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
                string NameOfTheMaterial_Manager = row.Cells["NameOfTheMaterial_Manager"].Value.ToString();
                string Unit_Manager = row.Cells["Unit_Manager"].Value.ToString();
                string LengthUnit_Manager = row.Cells["LengthUnit_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                //if (e.ColumnIndex == uiDataGridView1.Columns["Search"].Index && e.RowIndex >= 0)
                //{
                //    SpecificationsEdit frm = new SpecificationsEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}
                //// 确保点击的是按钮列
                //if (e.ColumnIndex == uiDataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
                //{
                //    SpecificationsEdit frm = new SpecificationsEdit(Column1, Column2, Column3);
                //    frm.Render();
                //    frm.ShowDialog();
                //    frm.Dispose();
                //}



                if (e.ColumnIndex == uiDataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
                {
                    if (ShowAskDialog("确定要删除吗？"))
                    {
                        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                        SpecificationSetting specification = capProjectDb.SpecificationSetting.Where(t => t.Id == Id).FirstOrDefault();
                        specification.IsDelete = 99;
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
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //dataTable.Rows.Add(NameOfTheMaterial.Text, Unit.Text, LengthUnit.Text, CreateTime.Text, CreateName.Text);

            if (ShowAskDialog("确定要添加吗？"))
            {

                if (string.IsNullOrEmpty(NameOfTheMaterial.Text))
                {
                    ShowWarningDialog("材料名称不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(Unit.Text))
                {
                    ShowWarningDialog("单位不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(LengthUnit.Text))
                {
                    ShowWarningDialog("长度（米）不能为空");
                    return;
                }

                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                SpecificationSetting specificationSetting = new SpecificationSetting();
                specificationSetting.Id = Guid.NewGuid().ToString();
                specificationSetting.NameOfTheMaterial = NameOfTheMaterial.Text;
                specificationSetting.Unit = Unit.Text;
                specificationSetting.LengthUnit = decimal.Parse(LengthUnit.Text);
                specificationSetting.CreateTime = DateTime.Now;
                specificationSetting.CreateName = _Name;
                //是否删除
                specificationSetting.IsDelete = 0;
                //添加数据
                capProjectDb.SpecificationSetting.InsertOnSubmit(specificationSetting);
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
                string NameOfTheMaterial_Manager = row.Cells["NameOfTheMaterial_Manager"].Value.ToString();
                string Unit_Manager = row.Cells["Unit_Manager"].Value.ToString();
                string LengthUnit_Manager = row.Cells["LengthUnit_Manager"].Value.ToString();
                string CreateTime_Manager = row.Cells["CreateTime_Manager"].Value.ToString();
                string CreateName_Manager = row.Cells["CreateName_Manager"].Value.ToString();


                Id = Id_Manager;
                NameOfTheMaterial.Text = NameOfTheMaterial_Manager;
                Unit.Text = Unit_Manager;
                LengthUnit.Text = LengthUnit_Manager;
                CreateTime.Text = CreateTime_Manager;
                CreateName.Text = CreateName_Manager;
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
            NameOfTheMaterial.Text = null;
            Unit.Text = null;
            LengthUnit.Text = null;
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

                if (string.IsNullOrEmpty(NameOfTheMaterial.Text))
                {
                    ShowWarningDialog("材料名称不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(Unit.Text))
                {
                    ShowWarningDialog("单位不能为空");
                    return;
                }

                if (string.IsNullOrEmpty(LengthUnit.Text))
                {
                    ShowWarningDialog("长度（米）不能为空");
                    return;
                }
                CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
                SpecificationSetting specification = capProjectDb.SpecificationSetting.Where(t => t.Id == Id).FirstOrDefault();
                specification.NameOfTheMaterial = NameOfTheMaterial.Text;
                specification.Unit = Unit.Text;
                specification.LengthUnit = decimal.Parse(LengthUnit.Text);
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
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //查询数据
            GetList();
        }
    }
}