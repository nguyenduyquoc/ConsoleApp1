using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Session1
{
    internal class Human
    {
        public string name;
        public int age;

        private string address;

        public Human()
        {

        }

        public Human(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        public void Eat()
        {
            Console.WriteLine("Eating.....");
        }

        public void Run()
        {
            Console.WriteLine(this.name + "is running...");
            
        }

       
    }
}
