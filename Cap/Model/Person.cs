using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public string Department { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Name + ", " + Age + ", " + Department;
        }
    }
}
