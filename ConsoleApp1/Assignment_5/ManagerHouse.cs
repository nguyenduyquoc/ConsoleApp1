using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        public static List<HaNoiHouse> manageHouse = new List<HaNoiHouse>();

        public List<HaNoiHouse> ManageHouse 
        { 
            get {return manageHouse; }
            set {manageHouse = value; } 
        }


        // hiển thị tất cả danh sách thông tin về các ngôi nhà
        public void DisplayAll()
        {
            for(int i = 0; i < ManageHouse.Count; i++)
            {
                Console.WriteLine("*** Ngoi nha thu " + (i + 1));
                ManageHouse[i].display();
                Console.WriteLine();
            }       
        }

        // sắp xếp danh sách ngôi nhà theo địa chỉ
        public void Sort()
        {
            ManageHouse.Sort((x, y) => x.DiaChi.CompareTo(y.DiaChi));
            DisplayAll();
        }

        // tìm kiếm danh sách thông tin ngôi nhà theo địa chỉ đc cung cấp
        public void Search(string diachi)
        {
            List<HaNoiHouse> ketqua = new List<HaNoiHouse>();
            foreach(HaNoiHouse h in ManageHouse)
            {
                if(diachi == h.DiaChi)
                {
                    ketqua.Add(h);
                }
            }
            if (ketqua.Count == 0)
            {
                Console.WriteLine("khong co ket qua phu hop");
            }
            else
            {
                for (int i = 0; i < ketqua.Count; i++)
                {
                    Console.WriteLine("ngoi nha thu " + (i + 1));
                    ketqua[i].display();
                }
            }
        }
        public void ShowMenu()
        {
            bool show = true;
            while (!show)
            {
                show = Menu();
            }
        }

        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Nhap thong tin ngoi nha");
            Console.WriteLine("2.Hien thi thong tin tat ca ngoi nha");
            Console.WriteLine("3.Sap xep theo truong dia chi");
            Console.WriteLine("4.Tim kiem theo dia chi nhap vao");
            Console.WriteLine("0.Thoat");
            Console.Write("MOI BAN NHAP LUA CHON: ");


            
            switch (Console.ReadLine())
            {
                case "0": 
                    return false;
                case "1":
                    Console.WriteLine();
                    HaNoiHouse h = new HaNoiHouse();
                    h.input();
                    ManageHouse.Add(h);
                    return true;
                case "2":
                    Console.WriteLine();
                    DisplayAll();             
                    return true;
                case "3":
                    Console.WriteLine();
                    Sort();
                    return true;
                case "4":
                    Console.WriteLine();
                    Console.Write("Nhap dia chi can tim kiem: ");
                    string diachi = Console.ReadLine();
                    Search(diachi);
                    return true;
                default:
                    return true;
            }
        }
    }
}
