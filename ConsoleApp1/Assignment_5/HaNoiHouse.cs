using house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class HaNoiHouse : House
    {
        private string tenQuan;

        public string TenQuan 
        {
            get { return tenQuan; }
            set { tenQuan = value; } 
        }

        public HaNoiHouse()
        {

        }

        public HaNoiHouse(string soNha, string diaChi, string loaiNha, string tenQuan) : base(soNha, diaChi, loaiNha)
        {
            this.TenQuan = tenQuan;
        }

        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap ten quan: ");
            TenQuan = Console.ReadLine();
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Ten quan : " + TenQuan);
        }
    }
}
