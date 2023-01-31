using house.hanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_6
{
    internal class StudentManage
    {
        public static List<Student> manageStudent = new List<Student>();

        public List<Student> ManageStudent
        {
            get { return manageStudent; }
            set { manageStudent = value; }
        }

        // HIEN THI DANH SÁCH SINH VIÊN
        public void DisplayAll()
        {
            for(int i = 0; i <  ManageStudent.Count; i++)
            {
                Console.WriteLine("Sinh vien thu " +i+1);
                ManageStudent[i].Display();
                Console.WriteLine();
            }
        }
        // THEM MOI SINH VIEN
        public void MoreStudents()
        {
            Student std = new Student();
            std.Input();
            int dem = 0;
            foreach(Student student in ManageStudent)
            {
                if(student.Id.Equals(std.Id))
                {
                    dem++;
                    Console.WriteLine("Id nay da co trong danh sach, ban vui long nhap lai");
                }
                break;
                
            }

            if (dem == 0)
            {
                ManageStudent.Add(std);
            }
        }

        // CAP NHAT THONG TIN SINH VIEN BOI ID
        public void UpDate(string id)
        {
            int dem = 0;
            foreach(Student student in ManageStudent)
            {
                if (student.Id.Equals(id))
                {
                    dem++;
                    Console.WriteLine("1.Sua ten sinh vien");
                    Console.WriteLine("2.Sua gioi tinh sinh vien");
                    Console.WriteLine("3.Sua tuoi sinh vien");
                    Console.WriteLine("4.Sua diem Toan sinh vien");
                    Console.WriteLine("5.Sua diem Ly sinh vien");
                    Console.WriteLine("6.Sua diem Hoa sinh vien");
                    Console.WriteLine("0.Thoat");
                    Console.Write("MOI BAN NHAP LUA CHON: ");
                    switch (Console.ReadLine())
                    {
                        case "0":
                            break;
                        case "1":
                            Console.WriteLine("Nhap lai ten sinh vien: ");
                            student.Name = Console.ReadLine();
                            break;
                        case "2":
                            Console.WriteLine("Nhap lai gioi tinh sinh vien: ");
                            student.Gender = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("Nhap lai tuoi sinh vien: ");
                            student.Age = Convert.ToInt32(Console.ReadLine());
                            break;
                        case "4":
                            Console.WriteLine("Nhap lai diem Toan sinh vien: ");
                            student.MathScore = Convert.ToInt32(Console.ReadLine());
                            student.averagingThreeSubjects();
                            student.rankedAcademic();
                            break;
                        case "5":
                            Console.WriteLine("Nhap lai diem Ly sinh vien: ");
                            student.PhysicsScore = Convert.ToInt32(Console.ReadLine());
                            student.averagingThreeSubjects();
                            student.rankedAcademic();
                            break;
                        case "6":
                            Console.WriteLine("Nhap lai diem Hoa sinh vien: ");
                            student.ChemistryScore = Convert.ToInt32(Console.ReadLine());
                            student.averagingThreeSubjects();
                            student.rankedAcademic();
                            break;
                        default:
                            break;

                    }
                }
                
            }
            if(dem == 0)
            {
                Console.WriteLine("Id khong nam trong list");
            }
        }


        // XÓA SINH VIÊN BỞI ID
        public void Delete(string id)
        {
            foreach (Student student in ManageStudent)
            {
                if (student.Id.Equals(id))
                {
                    ManageStudent.Remove(student);
                }
            }
        }

        // TÌM KIẾM SINH VIÊN THEO TÊN
        public void Search(string name)
        {
            List<Student> result= new List<Student>();
            foreach (Student student in ManageStudent)
            {
                if (student.Name.Equals(name))
                {
                    result.Add(student);    
                }
            }

            if(result.Count == 0)
            {
                Console.WriteLine("khong co ket qua tim kiem");
            }
            else
            {
                foreach (Student student in result)
                {
                    student.Display();
                }
            }
            
        }


        // SẮP XẾP THÔNG TIN SINH VIÊN THEO ĐIỂM TRUNG BÌNH
        public void SortByScore()
        {
            ManageStudent.Sort((x, y) => x.Average.CompareTo(y.Average));
            DisplayAll();
        }

        // SẮP XẾP THÔNG TIN SINH VIÊN THEO TÊN
        public void SortByName()
        {
            ManageStudent.Sort((x, y) => x.Name.CompareTo(y.Name));
            DisplayAll();
        }

        // SẮP XẾP THÔNG TIN SINH VIÊN THEO ID
        public void SortByID()
        {
            ManageStudent.Sort((x, y) => x.Id.CompareTo(y.Id));
            DisplayAll();
        }


        // vong lap cho Menu
        public void ShowMenu()
        {

            while (Menu() == true)
            {
                Menu();
            }
        }

        // Chuc nang chinh
        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Them sinh vien");
            Console.WriteLine("2.Cap nhat thong tin sinh vien boi ID");
            Console.WriteLine("3.Xoa ten sinh vien boi ID");
            Console.WriteLine("4.Tim kiem sinh vien theo ten");
            Console.WriteLine("5.Sap xep sinh vien theo diem trung binh");
            Console.WriteLine("6.Sap xep sinh vien theo ten");
            Console.WriteLine("7.Sap xep sinh vien theo ID");
            Console.WriteLine("8.Hien thi danh sach sinh vien");
            Console.WriteLine("0.Thoat");
            Console.Write("MOI BAN NHAP LUA CHON: ");



            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    Console.WriteLine();
                    MoreStudents();
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("Moi ban nhap Id sinh vien de cap nhat");
                    string idUpdate = Console.ReadLine();
                    UpDate(idUpdate);
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "3":
                    Console.WriteLine();
                    Console.WriteLine("Moi ban nhap Id sinh vien muon xoa");
                    string idDelete = Console.ReadLine();
                    Delete(idDelete);
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "4":
                    Console.WriteLine();
                    Console.WriteLine("Moi ban nhap ten sinh vien can tim kiem");
                    string name = Console.ReadLine();
                    Search(name);
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "5":
                    Console.WriteLine();
                    SortByScore();
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "6":
                    Console.WriteLine();
                    SortByName();
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "7":
                    Console.WriteLine();
                    SortByID();
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                case "8":
                    Console.WriteLine();
                    DisplayAll();
                    Console.WriteLine("Ban co muon tiep tuc chuong trinh khong???");
                    Console.WriteLine("1. Tiep tuc");
                    Console.WriteLine("2. Thoat chuong trinh");
                    Console.Write("Moi ban nhap lua chon: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return true;
                        case "2":
                            return false;
                        default:
                            return true;
                    }
                default:
                    return true;
            }
        }
    }
}
