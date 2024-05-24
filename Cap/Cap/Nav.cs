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
using Cap.SystemSetup.AlarmSetting;
using Cap.SystemSetup.Menu;
using Cap.SystemSetup.Role;
using Cap.SystemSetup.WidthOfCloth;
using Cap.WorkerManagementParent.WorkerManagement;
using Cap.WorkRecordsParent.WorkRecords;
using Model;
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
        CapDbContextDataContext capProjectDb = new CapDbContextDataContext();
        string _Name = string.Empty;
        bool _IsActive = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Name">登录人名称</param>
        /// <param name="Position">登录人职位</param>
        public Nav(string Name, string Position)
        {
            _Name = Name;
            InitializeComponent();

            #region 设置窗体全屏 
            this.WindowState = FormWindowState.Maximized;
            #endregion


            //string aa = "老板";
            Sys_Role sys_Role = capProjectDb.Sys_Role.Where(t => t.RoleName.Equals(Position)).FirstOrDefault(); //查询当前职位
            List<Sys_Menu> sys_MenuList = capProjectDb.Sys_Menu.ToList();


            bool XTSZ = false; //系统设置
            bool JCSZ = false; //基础设置
            bool GYSKH = false; //供应商/客户 
            bool KCGL = false;// 库存管理
            bool DD = false; //订单
            bool CW = false;

            TreeNode parent = null;
            int pageIndex = 1000;
            Sys_Menu xtsz_Manager = sys_MenuList.Where(t => t.Sort == 10000).FirstOrDefault(); //系统设置
            Sys_Menu jcsz_Manager = sys_MenuList.Where(t => t.Sort == 10001).FirstOrDefault(); //基础设置
            Sys_Menu gys_Manager = sys_MenuList.Where(t => t.Sort == 10002).FirstOrDefault(); //供应商/客户
            Sys_Menu kcgl_Manager = sys_MenuList.Where(t => t.Sort == 10003).FirstOrDefault(); //库存管理
            Sys_Menu dd_Manager = sys_MenuList.Where(t => t.Sort == 10004).FirstOrDefault(); //订单
            Sys_Menu cw_Manager = sys_MenuList.Where(t => t.Sort == 10005).FirstOrDefault(); //财务


            List<KeyValuePair<string, int>> values = new List<KeyValuePair<string, int>>();


            if (sys_Role.Sort != null)
            {
                string[] menu = sys_Role.Sort.TrimEnd(';').Split(';');

                for (int i = 0; i < menu.Length; i++)
                {
                    string num = menu[i];
                    Sys_Menu _Menu = sys_MenuList.Where(t => t.Sort == int.Parse(num)).FirstOrDefault();

                    #region 系统设置

                    if (num == "1")
                    {
                        if (XTSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(xtsz_Manager.MenuText, pageIndex));
                            parent = uiNavMenu1.CreateNode(xtsz_Manager.MenuText, int.Parse(xtsz_Manager.Icon), 24, pageIndex);
                            XTSZ = true;
                        }
                        SystemSetup.User user = new SystemSetup.User();
                        user.Text = _Menu.MenuText;
                        user.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(user, ++pageIndex)); //用户管理     1
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new SystemSetup.User(), ++pageIndex)); //用户管理     1
                    }
                    else if (num == "2")
                    {
                        if (XTSZ == false)
                        {
                            //parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);
                            values.Add(new KeyValuePair<string, int>(xtsz_Manager.MenuText, pageIndex));
                            parent = uiNavMenu1.CreateNode(xtsz_Manager.MenuText, int.Parse(xtsz_Manager.Icon), 24, pageIndex);
                            XTSZ = true;
                        }
                        Company company = new Company();
                        company.Text = _Menu.MenuText;
                        company.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(company, ++pageIndex));  //公司管理    2
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Company(), ++pageIndex));  //公司管理    2
                    }
                    else if (num == "3")
                    {
                        if (XTSZ == false)
                        {
                            //parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);
                            parent = uiNavMenu1.CreateNode(xtsz_Manager.MenuText, int.Parse(xtsz_Manager.Icon), 24, pageIndex);
                            XTSZ = true;
                        }
                        MenuBar menuBar = new MenuBar();
                        menuBar.Text = _Menu.MenuText;
                        menuBar.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(menuBar, ++pageIndex)); //菜单管理     3
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new MenuBar(), ++pageIndex)); //菜单管理     3
                    }
                    else if (num == "4")
                    {
                        if (XTSZ == false)
                        {
                            parent = uiNavMenu1.CreateNode(xtsz_Manager.MenuText, int.Parse(xtsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);
                            XTSZ = true;
                        }
                        Role role = new Role();
                        role.Text = _Menu.MenuText;
                        role.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(role, ++pageIndex)); //角色管理     4
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Role(), ++pageIndex)); //角色管理     4
                    }
                    else if (num == "5")
                    {
                        if (XTSZ == false)
                        {
                            parent = uiNavMenu1.CreateNode(xtsz_Manager.MenuText, int.Parse(xtsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("系统设置", 61451, 24, pageIndex);
                            XTSZ = true;
                        }
                        AlarmSetting alarmSetting = new AlarmSetting();
                        alarmSetting.Text = _Menu.MenuText;
                        alarmSetting.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(alarmSetting, ++pageIndex));  //告警设置    5
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new AlarmSetting(), ++pageIndex));  //告警设置    5

                    }
                    #endregion

                    #region 基础设置
                    else if (num == "6")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        WidthOfCloth widthOf = new WidthOfCloth(Name);
                        widthOf.Text = _Menu.MenuText;
                        widthOf.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(widthOf, ++pageIndex));    //6 幅宽设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new WidthOfCloth(), Guid.NewGuid()));    //6
                    }
                    else if (num == "7")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Perm perm = new Perm(Name);
                        perm.Text = _Menu.MenuText;
                        perm.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(perm, ++pageIndex));    // 7 烫头设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Perm(), Guid.NewGuid()));   //7
                    }
                    else if (num == "8")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        ToolSettings tool = new ToolSettings(Name);
                        tool.Text = _Menu.MenuText;
                        tool.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(tool, ++pageIndex));      //8  刀具设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new ToolSettings(), Guid.NewGuid()));//8
                    }
                    else if (num == "9")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Ingredients ingredients = new Ingredients(Name);
                        ingredients.Text = _Menu.MenuText;
                        ingredients.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(ingredients, ++pageIndex));   //9     主料设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Ingredients(), Guid.NewGuid())); //9
                    }
                    else if (num == "10")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Accessories accessories = new Accessories(Name);
                        accessories.Text = _Menu.MenuText;
                        accessories.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(accessories, ++pageIndex)); //10 辅料设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Accessories(), Guid.NewGuid())); //10
                    }
                    else if (num == "11")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }

                        Technology technology = new Technology(Name);
                        technology.Text = _Menu.MenuText;
                        technology.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(technology, ++pageIndex));  //11     工艺设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Technology(), Guid.NewGuid())); //11    
                    }
                    else if (num == "12")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Product product = new Product(Name);
                        product.Text = _Menu.MenuText;
                        product.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(product, ++pageIndex));  //12  产品设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Product(), Guid.NewGuid()));  //12
                    }
                    else if (num == "13")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Box box = new Box(Name);
                        box.Text = _Menu.MenuText;
                        box.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(box, ++pageIndex));   //13     箱规设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Box(), Guid.NewGuid()));  //13
                    }
                    else if (num == "14")
                    {
                        if (JCSZ == false)
                        {
                            values.Add(new KeyValuePair<string, int>(jcsz_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(jcsz_Manager.MenuText, int.Parse(jcsz_Manager.Icon), 24, pageIndex);
                            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
                            JCSZ = true;
                        }
                        Specifications specifications = new Specifications(Name);
                        specifications.Text = _Menu.MenuText;
                        specifications.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(specifications, ++pageIndex));  //14    规格设置
                        //uiNavMenu1.CreateChildNode(parent, AddPage(new Specifications(), Guid.NewGuid()));  //14
                    }
                    #endregion

                    #region 供应商/客户
                    else if (num == "15")
                    {
                        if (GYSKH == false)
                        {
                            values.Add(new KeyValuePair<string, int>(gys_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(gys_Manager.MenuText, int.Parse(gys_Manager.Icon), 24, pageIndex);
                            GYSKH = true;
                        }
                        Supplier supplier = new Supplier(Name);
                        supplier.Text = _Menu.MenuText;
                        supplier.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(supplier, ++pageIndex));    //15  供应商
                    }
                    else if (num == "16")
                    {
                        if (GYSKH == false)
                        {
                            values.Add(new KeyValuePair<string, int>(gys_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(gys_Manager.MenuText, int.Parse(gys_Manager.Icon), 24, pageIndex);
                            GYSKH = true;
                        }
                        Custom custom = new Custom(Name);
                        custom.Text = _Menu.MenuText;
                        custom.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(custom, ++pageIndex));//16  客户
                    }
                    #endregion

                    #region 库存管理
                    else if (num == "17")
                    {
                        if (KCGL == false)
                        {
                            values.Add(new KeyValuePair<string, int>(kcgl_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(kcgl_Manager.MenuText, int.Parse(kcgl_Manager.Icon), 24, pageIndex);
                            KCGL = true;
                        }
                        Inventory inventory = new Inventory(Name);
                        inventory.Text = _Menu.MenuText;
                        inventory.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(inventory, ++pageIndex));//17  库存
                    }
                    else if (num == "18")
                    {
                        if (KCGL == false)
                        {
                            values.Add(new KeyValuePair<string, int>(kcgl_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(kcgl_Manager.MenuText, int.Parse(kcgl_Manager.Icon), 24, pageIndex);
                            KCGL = true;
                        }
                        Inbound inbound = new Inbound(Name);
                        inbound.Text = _Menu.MenuText;
                        inbound.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(inbound, ++pageIndex));  //18   入库
                    }
                    else if (num == "19")
                    {
                        if (KCGL == false)
                        {
                            values.Add(new KeyValuePair<string, int>(kcgl_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(kcgl_Manager.MenuText, int.Parse(kcgl_Manager.Icon), 24, pageIndex);
                            KCGL = true;
                        }
                        Outbound outbound = new Outbound(Name);
                        outbound.Text = _Menu.MenuText;
                        outbound.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(outbound, ++pageIndex)); //19    出库
                    }
                    #endregion

                    #region 订单
                    else if (num == "20")
                    {
                        if (DD == false)
                        {
                            values.Add(new KeyValuePair<string, int>(dd_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(dd_Manager.MenuText, int.Parse(dd_Manager.Icon), 24, pageIndex);
                            DD = true;
                        }
                        OrderManagement orderManagement = new OrderManagement(Name);
                        orderManagement.Text = _Menu.MenuText;
                        orderManagement.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(orderManagement, ++pageIndex)); //20    订单管理
                    }
                    else if (num == "21")
                    {
                        if (DD == false)
                        {
                            values.Add(new KeyValuePair<string, int>(dd_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(dd_Manager.MenuText, int.Parse(dd_Manager.Icon), 24, pageIndex);
                            DD = true;
                        }
                        OrderSplitting orderSplitting = new OrderSplitting(Name);
                        orderSplitting.Text = _Menu.MenuText;
                        orderSplitting.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(orderSplitting, ++pageIndex)); //21    订单拆分
                    }
                    else if (num == "22")
                    {
                        if (DD == false)
                        {
                            values.Add(new KeyValuePair<string, int>(dd_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(dd_Manager.MenuText, int.Parse(dd_Manager.Icon), 24, pageIndex);
                            DD = true;
                        }
                        OrderAdditionalRecording orderAdditionalRecording = new OrderAdditionalRecording(Name);
                        orderAdditionalRecording.Text = _Menu.MenuText;
                        orderAdditionalRecording.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(orderAdditionalRecording, ++pageIndex));  //22  订单补录
                    }
                    else if (num == "23")
                    {
                        if (DD == false)
                        {
                            parent = uiNavMenu1.CreateNode(dd_Manager.MenuText, int.Parse(dd_Manager.Icon), 24, pageIndex);
                            DD = true;
                        }
                        WorkerManagement worker = new WorkerManagement(Name);
                        worker.Text = _Menu.MenuText;
                        worker.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(worker)); // 23 工人管理
                    }
                    else if (num == "24")
                    {
                        if (DD == false)
                        {
                            parent = uiNavMenu1.CreateNode(dd_Manager.MenuText, int.Parse(dd_Manager.Icon), 24, pageIndex);
                            DD = true;
                        }

                        WorkRecords workRecords = new WorkRecords(Name);
                        workRecords.Text = _Menu.MenuText;
                        workRecords.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(workRecords)); //24 工作记录
                    }
                    #endregion

                    #region 财务
                    else if (num == "25")
                    {
                        if (CW == false)
                        {
                            values.Add(new KeyValuePair<string, int>(cw_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }
                        FinancialJournal financialJournal = new FinancialJournal(Name);
                        financialJournal.Text = _Menu.MenuText;
                        financialJournal.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateChildNode(parent, AddPage(financialJournal, ++pageIndex));  //25  财务日账
                    }
                    else if (num == "26")
                    {
                        if (CW == false)
                        {
                            values.Add(new KeyValuePair<string, int>(cw_Manager.MenuText, ++pageIndex));
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }
                        FinancialStatements financialStatements = new FinancialStatements(Name);
                        financialStatements.Text = _Menu.MenuText;
                        financialStatements.Symbol = int.Parse(_Menu.Icon); 
                        uiNavMenu1.CreateChildNode(parent, AddPage(financialStatements, ++pageIndex));  //26  财务报表
                    }
                    else if (num == "27") 
                    {
                        if (CW == false)
                        {
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }

                        AttendanceManagement attendanceManagement = new AttendanceManagement(Name);
                        attendanceManagement.Text = _Menu.MenuText;
                        attendanceManagement.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(attendanceManagement));  //27  考勤管理
                    }
                    else if (num == "28")
                    {
                        if (CW == false)
                        {
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }
                        PurchasingManagement purchasingManagement = new PurchasingManagement(Name);
                        purchasingManagement.Text = _Menu.MenuText;
                        purchasingManagement.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(purchasingManagement)); // 28  采购管理
                    }
                    else if (num == "29")
                    {
                        if (CW == false)
                        {
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }
                        FixedAssets fixedAssets = new FixedAssets(Name);
                        fixedAssets.Text = _Menu.MenuText;
                        fixedAssets.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(fixedAssets));  //29   固定资产
                    }
                    else if (num == "30")
                    {
                        if (CW == false)
                        {
                            parent = uiNavMenu1.CreateNode(cw_Manager.MenuText, int.Parse(cw_Manager.Icon), 24, pageIndex);
                            CW = true;
                        }
                        AlarmManagement alarmManagement = new AlarmManagement(Name);
                        alarmManagement.Text = _Menu.MenuText;
                        alarmManagement.Symbol = int.Parse(_Menu.Icon);
                        uiNavMenu1.CreateNode(AddPage(alarmManagement)); //30    告警管理
                    }
                    #endregion
                }
            }


            uiNavBar1.Nodes.Add("主题");
            uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[0], 61502);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                uiNavBar1.CreateChildNode(uiNavBar1.Nodes[0], style.DisplayText(), style.Value());
            }

            int nm = 1;
            foreach (var kvp in values)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
                Sys_Menu Manager = sys_MenuList.Where(t => t.MenuText == kvp.Key).FirstOrDefault(); //系统设置
                uiNavBar1.Nodes.Add(kvp.Key);
                uiNavBar1.SetNodePageIndex(uiNavBar1.Nodes[nm], kvp.Value);
                uiNavBar1.SetNodeSymbol(uiNavBar1.Nodes[nm], int.Parse(Manager.Icon));
                nm++;
            }


            #region 之前的


            //parent = uiNavMenu1.CreateNode("基础设置", 61818, 24, pageIndex);
            //uiNavMenu1.CreateChildNode(parent, AddPage(new WidthOfCloth(), Guid.NewGuid()));    //6
            ////uiNavMenu1.CreateChildNode(parent, AddPage(new Perm(), Guid.NewGuid()));            //7
            //uiNavMenu1.CreateChildNode(parent, AddPage(new ToolSettings(), Guid.NewGuid()));    //8
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Ingredients(), Guid.NewGuid()));     //9
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Accessories(), Guid.NewGuid()));      //10
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Technology(), Guid.NewGuid()));     //11
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Product(), Guid.NewGuid()));        //12
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Box(), Guid.NewGuid()));             //13
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Specifications(), Guid.NewGuid()));  //14



            //parent = uiNavMenu1.CreateNode("供应商/客户", 61950, 24, pageIndex);
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Supplier()));  //15
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Custom()));  //16


            //parent = uiNavMenu1.CreateNode("库存管理", 362614, 24, pageIndex);
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Inventory())); //17
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Inbound()));   //18
            //uiNavMenu1.CreateChildNode(parent, AddPage(new Outbound()));  //19


            //parent = uiNavMenu1.CreateNode("订单", 362614, 24, pageIndex);
            //uiNavMenu1.CreateChildNode(parent, AddPage(new OrderManagement())); //20
            //uiNavMenu1.CreateChildNode(parent, AddPage(new OrderSplitting()));  //21
            //uiNavMenu1.CreateChildNode(parent, AddPage(new OrderAdditionalRecording()));  //22
            //uiNavMenu1.CreateNode(AddPage(new WorkerManagement())); // 23
            //uiNavMenu1.CreateNode(AddPage(new WorkRecords())); //24

            //parent = uiNavMenu1.CreateNode("财务", 362614, 24, pageIndex);
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialJournal())); //25
            //uiNavMenu1.CreateChildNode(parent, AddPage(new FinancialStatements())); //26
            //uiNavMenu1.CreateNode(AddPage(new AttendanceManagement()));  //27
            //uiNavMenu1.CreateNode(AddPage(new PurchasingManagement())); // 28
            //uiNavMenu1.CreateNode(AddPage(new FixedAssets()));  //29
            //uiNavMenu1.CreateNode(AddPage(new AlarmManagement())); //30
            #endregion

            //选中第一个节点
            uiNavMenu1.SelectPage(1002);
            uiNavMenu1.Font = new System.Drawing.Font("宋体", 12); // 这里设置为 宋体 字体，大小为 12
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
                case 0:
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


        private void timer1_Tick(object sender, EventArgs e)
        {


            DateTime now = DateTime.Now;
            string timeOfDay = null;

            if (now.Hour >= 5 && now.Hour < 12)
            {
                timeOfDay = "早上好";
            }
            else if (now.Hour >= 12 && now.Hour < 18)
            {
                timeOfDay = "下午好";
            }
            else if (now.Hour >= 18 && now.Hour < 21)
            {
                timeOfDay = "傍晚好";
            }
            else
            {
                timeOfDay = "晚上好";
            }


            uiLabel2.Text = DateTime.Now.DateTimeString();
            uiLabel1.Text = timeOfDay + _Name;
        }


        /// <summary>
        /// 关闭时操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nav_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//关闭的时候杀死所有线程
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button29_Click(object sender, EventArgs e)
        {

            if (ShowAskDialog("确定要退出吗？"))
            {
                Application.Exit();//关闭的时候杀死所有线程
            } 
        }
    }
}
