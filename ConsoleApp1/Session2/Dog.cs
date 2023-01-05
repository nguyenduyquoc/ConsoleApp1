using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Session2
{
    internal class Dog : Animal , IAnimal , IDog
    {

        private double weight;

        private string color;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public Dog()
        {

        }

        public Dog(string kind, double weight , string color) :base(kind)
        {
            this.weight = weight;
            this.color = color;
        }

        public void Infor()
        {
            Console.WriteLine(GetKind());
        }

        public sealed override void SetKind(string kind)
        {
            base.SetKind(kind);
        }
    }
}
