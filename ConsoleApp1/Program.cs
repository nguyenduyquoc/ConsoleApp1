using ConsoleApp1.Assignment_1;
using ConsoleApp1.Session1;
using ConsoleApp1.Session2;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //int x = 10;
        //double y = 3.14;
        //Console.WriteLine("Hello world: " + x);
        //string s = "T2204M";

        //int[] ns = new int[3];
        //ns[0] = 15;
        //ns[1] = 20;
        //ns[2] = 25;

        //foreach (int n in ns)
        //{
        //    // n
        //}

        //for (int i = 0; i < ns.Length; i++)
        //{
        //    // n[i]
        //}

        //     INPUT AND OUTPUT
        //string input = Console.ReadLine(); // scan
        //int num = Convert.ToInt32(input);
        //Console.WriteLine("num = " + num);

        //    CLASS AND OBJECT
        Human h = new Human();
        h.name = "Hoang Duy Quoc";
        h.Run();


        // ---------------- TEST ASSIGNMENT 1 ----------------

        Fraction f1 = new Fraction();
        Console.WriteLine("Phan so f1:");
        Console.WriteLine("Nhap tu so: ");
        f1.TuSo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap mau so: ");
        f1.MauSo = Convert.ToInt32(Console.ReadLine());

        f1.InPhanSo();
        f1.RutGon();
        f1.InPhanSo();


        Dog d = new Dog("husky", 20, "black");
        
        d.Color = "yellow";
        d.Weight = 20;

        Console.WriteLine(d.Weight);

        Dog[] dogs = new Dog[10];

        for(int i = 0; i < dogs.Length; i ++)
        {
            dogs[i] = new Dog();
        }

        foreach(Dog o in dogs)
        {
            o.Color = "black";
        }

        List<Dog> doglist = new List<Dog>();
        doglist.Add(new Dog());
        Console.WriteLine(doglist.Count);

        List<int> listint = new List<int>();
     

       


    }
}
