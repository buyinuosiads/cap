﻿using Cap.AlarmManagementParent.AlarmManagement;
using Cap.AttendanceManagementParent.AttendanceManagement;
using Cap.BasicSettings.Accessories;
using Cap.BasicSettings.Box;
using Cap.BasicSettings.Ingredients;
using Cap.BasicSettings.Perm;
using Cap.BasicSettings.Product;
using Cap.BasicSettings.Specifications;
using Cap.BasicSettings.Technology;
using Cap.BasicSettings.ToolSettings;
using Cap.Finance.FinancialJournal;
using Cap.Finance.FinancialStatements;
using Cap.FixedAssetsParent.FixedAssets;
using Cap.InventoryManagement.Inbound;
using Cap.InventoryManagement.Inventory;
using Cap.InventoryManagement.Outbound;
using Cap.Order.OrderAdditionalRecording;
using Cap.Order.OrderManagement;
using Cap.Order.OrderSplitting;
using Cap.PurchasingManagementParent.PurchasingManagement;
using Cap.SupplierAndCustom.Custom;
using Cap.SupplierAndCustom.Supplier;
using Cap.SystemSetup;
using Cap.SystemSetup.AlarmSetting;
using Cap.SystemSetup.Menu;
using Cap.SystemSetup.Role;
using Cap.SystemSetup.WidthOfCloth;
using Cap.WorkerManagementParent.WorkerManagement;
using Cap.WorkRecordsParent.WorkRecords;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cap
{
    public partial class Nav : UIForm2
    {
        public Nav()
        {
            InitializeComponent();

            #region 设置窗体全屏 
            this.WindowState = FormWindowState.Maximized;
            #endregion


            int pageIndex = 1000;

            //uiNavBar1设置节点，也可以在Nodes属性里配置
            //uiNavBar1.Nodes.Add("系统设置");
            //uiNavBar1.Nodes.Add("基础设置");
            //uiNavBar1.Nodes.Add("供应商/客户");
            //uiNavBar1.Nodes.Add("库存管理");
            //uiNavBar1.Nodes.Add("订单");
            //uiNavBar1.Nodes.Add("工人管理");
            //uiNavBar1.Nodes.Add("工作记录");
            //uiNavBar1.Nodes.Add("考勤管理");
            //uiNavBar1.Nodes.Add("采购管理");
            //uiNavBar1.Nodes.Add("财务");
            //uiNavBar1.Nodes.Add("固定资产");
            //uiNavBar1.Nodes.Add("告警管理");



            TreeNode parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);

            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            uiNavMenu1.CreateChildNode(parent, AddPage(new SystemSetup.User(), ++pageIndex)); //用户管理
            uiNavMenu1.CreateChildNode(parent, AddPage(new Company(), ++pageIndex));  //公司管理
            uiNavMenu1.CreateChildNode(parent, AddPage(new MenuBar(), ++pageIndex)); //菜单管理
            uiNavMenu1.CreateChildNode(parent, AddPage(new Role(), ++pageIndex)); //角色管理
            uiNavMenu1.CreateChildNode(parent, AddPage(new AlarmSetting(), ++pageIndex));  //告警设置
            //示例设置某个节点的小红点提示
            //uiNavMenu1.ShowTips = true;


            pageIndex = 2000;
            parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
            //通过设置GUID关联，节点字体图标和大小由UIPage设置
            uiNavMenu1.CreateChildNode(parent, AddPage(new WidthOfCloth(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Perm(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new ToolSettings(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Ingredients(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Accessories(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Technology(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Product(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Box(), Guid.NewGuid()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Specifications(), Guid.NewGuid()));



            pageIndex = 3000;
            parent = uiNavMenu1.CreateNode("供应商/客户", 61950, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new Supplier()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Custom()));


            pageIndex = 4000;
            parent = uiNavMenu1.CreateNode("库存管理", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new Inventory()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Inbound()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Outbound()));



            pageIndex = 5000;
            parent = uiNavMenu1.CreateNode("订单", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderManagement()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderSplitting()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderAdditionalRecording()));


            pageIndex = 6000;
            uiNavMenu1.CreateNode(AddPage(new WorkerManagement()));


            pageIndex = 7000;
            uiNavMenu1.CreateNode(AddPage(new WorkRecords()));


            pageIndex = 8000;
            parent = uiNavMenu1.CreateNode("财务", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialJournal()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialStatements()));


            uiNavMenu1.CreateNode(AddPage(new AttendanceManagement()));
            uiNavMenu1.CreateNode(AddPage(new PurchasingManagement()));
            uiNavMenu1.CreateNode(AddPage(new FixedAssets()));
            uiNavMenu1.CreateNode(AddPage(new AlarmManagement()));



            //选中第一个节点
            uiNavMenu1.SelectPage(1002);


            timer1.Start();
        }

        /// <summary>
        /// 创建对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fullName">命名空间.类型名</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string fullName)
        {
            Type o = Type.GetType(fullName);
            dynamic obj = Activator.CreateInstance(o, true);
            return (T)obj;//类型转换并返回
        }


        private void uiNavBar1_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 4:
                    UIStyle style = (UIStyle)pageIndex;
                    if (pageIndex < UIStyle.Colorful.Value())
                        StyleManager.Style = style;
                    else
                        uiNavMenu1.SelectPage(pageIndex);
                    break;
                default:
                    uiNavMenu1.SelectPage(pageIndex);
                    break;
            }
        }


    }
}
