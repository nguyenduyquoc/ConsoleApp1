using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Assignment_6
{

    enum AcademicAbility
    {
        Excellent,
        Good,
        Average,
        Weak
    }
    internal class Student
    {
        private string id;               // id
        private string name;             // tên sinh viên
        private string gender;           // giới tính
        private int age;                 // tuổi
        private float mathScore;         // điểm môn toán
        private float physicsScore;      // điểm môn lý
        private float chemistryScore;    // điểm môn hóa
        private float average;           // điểm trung bình cộng
        private AcademicAbility academicAbility;  // học lực


        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public float MathScore { get; set; }
        public float PhysicsScore { get; set; }
        public float ChemistryScore { get; set; }
        public float Average { get; private set; }
        public AcademicAbility AcademicAbility { get; private set; }

        public Student()
        {

        }

        public Student(string id, string name, string gender, int age, float mathScore, float physicsScore, float chemistryScore, float average, AcademicAbility academicAbility)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
            MathScore = mathScore;
            PhysicsScore = physicsScore;
            ChemistryScore = chemistryScore;
            Average = average;
            AcademicAbility = academicAbility;
        }


        // hàm tính trung bình cộng ba môn Toán - Lý - Hóa
        public void averagingThreeSubjects()
        {
            Average = (MathScore + PhysicsScore + ChemistryScore) / 3;
        }


        // hàm xét học lực dựa trên điểm trung bình cộng ba môn
        public void rankedAcademic()
        {
            if (Average >= 8)
            {
                AcademicAbility = AcademicAbility.Excellent;
            } else if (Average >= 6.5 && Average < 8)
            {
                AcademicAbility = AcademicAbility.Good;
            } else if (Average >= 5 && Average < 6.5)
            {
                AcademicAbility = AcademicAbility.Average;
            } else if (Average < 5)
            {
                AcademicAbility = AcademicAbility.Weak;
            }
        }

        // hàm nhập thông tin sinh viên
        public void Input()
        {
            Console.WriteLine("Moi ban nhao thong tin sinh vien");
            Console.WriteLine("Id : ");
            Id = Console.ReadLine();
            Console.WriteLine("Ten sinh vien : ");
            Name = Console.ReadLine();
            Console.WriteLine("Gioi tinh : ");
            Gender = Console.ReadLine();
            Console.WriteLine("Tuoi : ");
            Age = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Diem mon Toan : ");
            MathScore = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Diem mon Ly : ");
            PhysicsScore = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diem mon Hoa : ");
            ChemistryScore = Convert.ToInt32(Console.ReadLine());
            averagingThreeSubjects();
            rankedAcademic();
        }

        public void Display()
        {
            Console.WriteLine("Id : " + Id);
            Console.WriteLine("Ten sinh vien : " + Name);
            Console.WriteLine("Gioi tinh : " + Gender);
            Console.WriteLine("Tuoi : " + Age);
            Console.WriteLine("Diem mon Toan : " + MathScore);
            Console.WriteLine("Diem mon Ly : " + PhysicsScore);
            Console.WriteLine("Diem mon Hoa : " + ChemistryScore);
            Console.WriteLine("Diem Trung binh cong : " + Average);
            Console.WriteLine("Xep loai hoc luc : " + AcademicAbility);
        }
    }
}
