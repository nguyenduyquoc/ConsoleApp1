using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Session2
{
    internal class Animal : AbstractAnimal
    {
        private string kind;

        public Animal()
        {

        }

        public Animal(string kid)
        {
            this.kind = kind;
        }

        public virtual void SetKind(string kind)
        {
            this.kind = kind;
        }

        public string GetKind()
        {
            return this.kind;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating....");
        }

        public override void Run()
        {
            Console.WriteLine("Running....");
        }
    }
}
