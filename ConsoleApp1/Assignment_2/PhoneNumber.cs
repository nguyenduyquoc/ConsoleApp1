using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_2
{
    internal class PhoneNumber
    {
        private string name;
        private List<string> tel = new List<string>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Tel 
        {
            get { return tel ; }
            set { tel = value ; } 
        }


        public PhoneNumber() {
        }
        public PhoneNumber(string name, List<string> tel)
        {
            Name = name;
            Tel = tel;
        }

        public override string? ToString()
        {
            return this.Name + this.Tel;
        }
    }
}
