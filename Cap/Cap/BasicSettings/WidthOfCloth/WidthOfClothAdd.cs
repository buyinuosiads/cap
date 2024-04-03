using Model;
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

namespace Cap.SystemSetup
{
    public partial class WidthOfClothAdd : UIEditForm
    {
        public WidthOfClothAdd()
        {
            InitializeComponent();
        }


        protected override bool CheckData()
        {
            return CheckEmpty(edtName, "请输入幅宽名称")
                   && CheckEmpty(edtAge, "请输入幅宽大小");
        }

        private Person person;

        public Person Person
        {
            get
            {
                if (person == null)
                {
                    person = new Person();
                }

                person.Name = edtName.Text;
                person.Age = edtAge.IntValue;

                return person;
            }

            set
            {
                person = value;
                edtName.Text = value.Name;
                edtAge.IntValue = value.Age;
            }
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void WidthOfClothAdd_Load(object sender, EventArgs e)
        {

        }

        private void edtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
