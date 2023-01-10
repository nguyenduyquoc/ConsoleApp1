using ConsoleApp1.Assignment_1;
using ConsoleApp1.Assignment_2;
using ConsoleApp1.Assignment_4;
using ConsoleApp1.Session1;
using ConsoleApp1.Session2;
using ConsoleApp1.Session4;
using System;

public class Program
{
    public static void Main(string[] args)
    {

        News n1 = new News();
        n1.Id = 1212;
        n1.Title = "hfejkfhsf";
        n1.Author = "háhfkshfkasf";
        n1.Content = "sfkasfhaskf";
        n1.PublishDate = "22-3-2012";
        n1.RateList[0] = 5;
        n1.RateList[1] = 3;
        n1.RateList[2] = 2;
        n1.Calculate();
        n1.Display();

        
     //   int x = 10;
     //   double y = 3.14;
     //   Console.WriteLine("Hello world: " + x);
     //   string s = "T2204M";

     //   int[] ns = new int[3];
     //   ns[0] = 15;
     //   ns[1] = 20;
     //   ns[2] = 25;

     //   foreach (int n in ns)
     //   {
     //     n
     //   }

     //   for (int i = 0; i < ns.Length; i++)
     //   {
     //       n[i]
     //   }

     //   INPUT AND OUTPUT
     //   string input = Console.ReadLine(); // scan
     //   int num = Convert.ToInt32(input);
     //   Console.WriteLine("num = " + num);

     //   CLASS AND OBJECT
        Human h = new Human();
        h.name = "Hoang Duy Quoc";
        h.Run();


        // ---------------- TEST ASSIGNMENT 1 ----------------

     //   Fraction f1 = new Fraction();
     //   Console.WriteLine("Phan so f1:");
     //   Console.WriteLine("Nhap tu so: ");
     //   f1.TuSo = Convert.ToInt32(Console.ReadLine());
     //   Console.WriteLine("Nhap mau so: ");
     //   f1.MauSo = Convert.ToInt32(Console.ReadLine());

     //   f1.InPhanSo();
     //   f1.RutGon();
     //   f1.InPhanSo();


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

       // List<Dog> doglist = new List<Dog>();
        //doglist.Add(new Dog());
        //Console.WriteLine(doglist.Count);

       // List<int> listint = new List<int>();



        // Asignment-2

        PhoneBook pb1 = new PhoneBook();
        pb1.InsertPhone("nguyen duy quoc", "0962027042");
        pb1.InsertPhone("hoang duy quoc", "0962027052");
        pb1.InsertPhone("nguyen duy khanh", "0962027642");
        pb1.InsertPhone("nguyen duy khanh", "0962027644");
        pb1.InsertPhone("sfkashkfashfsdfha", "0962024844");


       

        foreach (PhoneNumber pn in pb1.PhoneList)
        {
            foreach (string n in pn.Tel)
            {
                Console.WriteLine(pn.Name + " - " + n);
            }

        }







    }

    public static void Main1(string[] args)
    {
    //    DemoDelegate.Alert("Cam thanh vien duoi 1 tuoi");

    //    DemoDelegate d = new DemoDelegate();
     //   d.ShowMessage("Canh bao lan thu nhat");


        PrintString ps = new PrintString(ShowDanger);
     //   ps("nguy hiem");

    //    PrintString ps1 = new PrintString(DemoDelegate.Alert);
     //   PrintString ps2 = new PrintString(new DemoDelegate().ShowMessage);



        ps += DemoDelegate.Alert;
        ps += new DemoDelegate().ShowMessage;
        ps("nguy hiem lam");


        ps += (s) =>
        {
            Console.WriteLine("Anonymus" + s);
        };

        ps += delegate (string s)
        {
            Console.WriteLine("Anonymus" + s);
        };

        PrintString ps3 = delegate (string s)
        {
            Console.WriteLine("Anonymus" + s);
        };



        Button de = new Button(ps3);
        de.ClickAction();
    }


    public static void ShowDanger(string mg)
    {
        Console.WriteLine("Danger :" + mg);
    }
}
