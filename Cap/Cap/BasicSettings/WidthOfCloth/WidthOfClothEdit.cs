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

namespace Cap.BasicSettings.WidthOfCloth
{
    public partial class WidthOfClothEdit : UIEditForm
    {
        public WidthOfClothEdit(string Column1, string Column2)
        {
            InitializeComponent();
            edtName.Text = Column1;
            edtAge.Text = Column2;
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

        private void edtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sss = edtName.Text;
        }

        private void edtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
