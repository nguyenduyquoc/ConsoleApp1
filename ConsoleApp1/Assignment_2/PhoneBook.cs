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

        //Constructors
        public PhoneBook() { }
        public PhoneBook(List<PhoneNumber> phoneList)
        {
            this.PhoneList = phoneList;
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
                            return;
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
            foreach (PhoneNumber phn in phonelist)
            {
                if (phn.Name.Equals(name))
                {
                    phonelist.Remove(phn);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber phn2 in phonelist)
            {
                if (phn2.Name.Equals(name))
                {
                    return phn2;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {
            foreach (PhoneNumber phn in phonelist)
            {
                if ( phn.Name.Equals(name) ) {
                    phn.Tel.Remove(oldPhone);
                    phn.Tel.Add(newPhone);
                    return;
                }
            }
        }
    }
}
