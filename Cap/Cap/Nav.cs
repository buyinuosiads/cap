using Cap.AlarmManagementParent.AlarmManagement;
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
using Cap.SystemSetup.WidthOfCloth;
using Cap.WorkerManagementParent.WorkerManagement;
using Cap.WorkRecordsParent.WorkRecords;
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
using System.Xml.Linq;

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
            uiNavBar1.Nodes.Add("系统设置");
            uiNavBar1.Nodes.Add("基础设置");
            uiNavBar1.Nodes.Add("供应商/客户");
            uiNavBar1.Nodes.Add("库存管理");
            uiNavBar1.Nodes.Add("订单");
            uiNavBar1.Nodes.Add("工人管理");
            uiNavBar1.Nodes.Add("工作记录");
            uiNavBar1.Nodes.Add("考勤管理");
            uiNavBar1.Nodes.Add("采购管理");
            uiNavBar1.Nodes.Add("财务");
            uiNavBar1.Nodes.Add("固定资产");
            uiNavBar1.Nodes.Add("告警管理");



            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[0], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 61451);
            TreeNode parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);

            //通过设置PageIndex关联，节点文字、图标由相应的Page的Text、Symbol提供
            uiNavMenu1.CreateChildNode(parent, AddPage(new Company(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FButton(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FCheckBox(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FCombobox(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FContextMenuStrip(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FDataGridView(), ++pageIndex)); 
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Form3(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FFlowLayoutPanel(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FHeaderButton(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FLabel(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FLine(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FListBox(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FNavigation(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FPanel(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FProcess(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FRadioButton(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FScrollBar(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FSplitContainer(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FTabControl(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FTextBox(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FTransfer(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FTreeView(), ++pageIndex));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FOther(), ++pageIndex));
            //示例设置某个节点的小红点提示
            uiNavMenu1.ShowTips = true;
            //uiNavMenu1.SetNodeTipsText(uiNavMenu1.Nodes[0], "0", Color.Red, Color.White);
            //uiNavMenu1.SetNodeTipsText(parent.Nodes[1], " ", Color.Lime, Color.White);


            pageIndex = 2000;
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[0], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 61818);
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
            
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FEditor(), Guid.NewGuid()));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FFrames(), Guid.NewGuid()));

            pageIndex = 3000;
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[1], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 61950);
            parent = uiNavMenu1.CreateNode("供应商/客户", 61950, 24, pageIndex);
            //直接关联（默认自动生成GUID）
            uiNavMenu1.CreateChildNode(parent, AddPage(new Supplier()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Custom()));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FDoughnutChart()));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FLineChart()));
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FPieChart()));

            pageIndex = 4000;
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[2], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            parent = uiNavMenu1.CreateNode("库存管理", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new Inventory()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Inbound()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new Outbound()));
            //直接关联（默认自动生成GUID）
            //uiNavMenu1.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FPipe")));
            //uiNavMenu1.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FMeter")));
            //uiNavMenu1.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FLed")));
            //uiNavMenu1.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FLight")));
            //uiNavMenu1.CreateChildNode(parent, AddPage(CreateInstance<UIPage>("Sunny.UI.Demo.FSwitch")));


            pageIndex = 5000;
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[3], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            parent = uiNavMenu1.CreateNode("订单", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderManagement()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderSplitting()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new OrderAdditionalRecording()));


            //pageIndex = 6000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[4], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);

            //var node = uiNavBar1.CreateChildNode(uiNavBar1.Nodes[4], "工人管理", UIStyle.Colorful.Value());
            //uiNavBar1.SetNodeSymbol(node, 558295);
            uiNavMenu1.CreateNode(AddPage(new WorkerManagement()));
            //parent = uiNavMenu1.CreateNode("工人管理", 362614, 24, pageIndex);


            //pageIndex = 7000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[5], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            //parent = uiNavMenu1.CreateNode("工作记录", 362614, 24, pageIndex);

            uiNavMenu1.CreateNode(AddPage(new WorkRecords()));

            //pageIndex = 8000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[6], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            //parent = uiNavMenu1.CreateNode("考勤管理", 362614, 24, pageIndex);

            uiNavMenu1.CreateNode(AddPage(new AttendanceManagement()));

            //pageIndex = 9000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[7], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            //parent = uiNavMenu1.CreateNode("采购管理", 362614, 24, pageIndex);

            uiNavMenu1.CreateNode(AddPage(new PurchasingManagement()));

            pageIndex = 10000;
            uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[8], pageIndex);
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            parent = uiNavMenu1.CreateNode("财务", 362614, 24, pageIndex);
            uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialJournal()));
            uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialStatements()));

            //pageIndex = 11000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[9], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            //parent = uiNavMenu1.CreateNode("固定资产", 362614, 24, pageIndex);

            uiNavMenu1.CreateNode(AddPage(new FixedAssets()));


            //pageIndex = 12000;
            //uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[10], pageIndex);
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 362614);
            //parent = uiNavMenu1.CreateNode("告警管理", 362614, 24, pageIndex);

            uiNavMenu1.CreateNode(AddPage(new AlarmManagement()));

            #region 主题
            //uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[11], 61502);
            //var styles = UIStyles.PopularStyles();
            //foreach (UIStyle style in styles)
            //{
            //    uiNavBar1.CreateChildNode(uiNavBar1.Nodes[4], style.DisplayText(), style.Value());
            //}

            //var node = uiNavBar1.CreateChildNode(uiNavBar1.Nodes[4], "字体图标", 99999);
            //uiNavBar1.SetNodeSymbol(node, 558426);
            //node = uiNavBar1.CreateChildNode(uiNavBar1.Nodes[4], "多彩主题", UIStyle.Colorful.Value());
            //uiNavBar1.SetNodeSymbol(node, 558295);
            #endregion



            //左侧导航主节点关联页面
            //uiNavMenu1.CreateNode(AddPage(new FSymbols()));
            //uiNavMenu1.CreateNode(AddPage(new FColorful()));

            //直接增加一个页面，不在左侧列表显示
            //AddPage(new FColorful());
            //AddPage(new FCommon());

            //选中第一个节点
            uiNavMenu1.SelectPage(1002);

            //uiPanel2.Text = Text = Version;
            //RegisterHotKey(Sunny.UI.ModifierKeys.Shift, Keys.F8);

            //根据页面类型获取页面
            //FButton page = GetPage<FButton>();
            //if (page != null)
            //    page.Text.WriteConsole();

            //根据页面索引获取页面
            //UIPage page1 = GetPage(1002);
            //if (page1 != null)
            //    page1.Text.WriteConsole();

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

    }
}
