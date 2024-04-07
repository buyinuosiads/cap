using Model;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cap.SystemSetup.Menu
{
    public partial class MenuBarAdd : UIEditForm
    {

        //CapProjectDataContext capProjectDb = new CapProjectDataContext();
        public MenuBarAdd()
        {
            InitializeComponent();
         

            //var sysmenu = capProjectDb.Sys_Menu.ToList();
 
            //IList<Info> infoList = new List<Info>();
            //for (int i = 0; i < 1; i++)
            //{
            //    infoList.Add(new Info() { Id = "00000000-0000-0000-0000-000000000000", Name = "----作为顶级菜单------" });
            //}
             



        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Sys_Menu sys_Menu = new Sys_Menu();
            //sys_Menu.Id = Guid;
            //sys_Menu.ParentId = Guid;
            //sys_Menu.MenuText = MenuText.Text;
            //sys_Menu.CreateTime = DateTime.Now;
            //sys_Menu.Status = 0;
            //capProjectDb.Sys_Menu.InsertOnSubmit(sys_Menu);
            //capProjectDb.SubmitChanges();

        }

        public class Info
        {
            public string Id { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return "ID: " + Id + ", Name: " + Name;
            }
        }


    }
}
