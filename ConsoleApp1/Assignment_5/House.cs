using ConsoleApp1.Assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.cm
{
    internal class House : IHouse
    {
        private string soNha;

        private string diaChi;

        private string loaiNha;

        public string SoNha 
        {
            get {return soNha; }
            set {soNha = value; } 
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string LoaiNha
        {
            get { return loaiNha; }
            set { loaiNha = value; }
        }


        public House()
        {

        }
        public House(string soNha, string diaChi, string loaiNha)
        {
            SoNha = soNha;
            DiaChi = diaChi;
            LoaiNha = loaiNha;
        }

        public virtual void input()
        {
            
            Console.WriteLine("***Moi nhap thong tin:");
            Console.WriteLine("* Nhap so nha: ");
            SoNha = Console.ReadLine();
            Console.WriteLine("* Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("* Nhap loai nha: ");
            LoaiNha = Console.ReadLine();

        }

        public virtual void display()
        {
            Console.WriteLine("* so nha   : " + SoNha);
            Console.WriteLine("* dia chi  : " + DiaChi);
            Console.WriteLine("* loai nha : " + LoaiNha);
        }
    }
}
