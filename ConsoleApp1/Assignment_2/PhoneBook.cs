using ConsoleApp1.Session2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_2
{
    internal class PhoneBook : AbstractPhone
    {


        List<PhoneNumber> phonelist = new List<PhoneNumber>();

        public List<PhoneNumber> PhoneList {
            get { return phonelist; }
            set {phonelist = value; }
        }

        public override void InsertPhone(string name, string phone)
        {
            Boolean dem = false;
            Boolean dem2 = false;
            
            foreach( PhoneNumber phn in phonelist )
            {
                if( phn.Name.Equals(name) )
                {
                    dem = true;
                    foreach(String t in phn.Tel)
                    {
                        if (t.Equals(phone))
                        {
                            dem2 = true;
                            break;
                        }
                    }
                    if(!dem2)
                    {
                        phn.Tel.Add(phone);
                    }
                }
            }

            if( !dem )
            {
                List<string> tel = new List<string>();
                tel.Add(phone);
                this.phonelist.Add(new PhoneNumber(name, tel));
            }
        }

        public override void RemovePhone(string name)
        {
            throw new NotImplementedException();
        }

        public override PhoneBook SearchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void Sort()
        {
            throw new NotImplementedException();
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}
