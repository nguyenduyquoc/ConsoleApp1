using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Assignment_4
{
    internal class News : INews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title 
        {
            get { return title; }
            set { title = value; }
        }
        public string PublishDate 
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        public string Author 
        {
            get { return author; }
            set { author = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public float  AverageRate
        {
            get { return averageRate; }
        }


        public News()
        {

        }

        public News(int id, string title, string publishDate, string author, string content)
        {
            Id = id;
            Title = title;
            PublishDate = publishDate;
            Author = author;
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine( "Id : " + Id );
            Console.WriteLine( "Title : " + Title );
            Console.WriteLine( "PublishDate : " + PublishDate );
            Console.WriteLine( "Author : " + Author );
            Console.WriteLine( "Content : " + Content );
            Console.WriteLine("AverageRate: " + AverageRate );
        }

        private int[] rateList = new int[3];


        public int[] RateList
        {
            get { return rateList; }
            set { rateList = value; }
        }
     
     //   viết như cách này cũng đc

     //   public int this[int index]
     //   {
     //       get { return rateList[index]; }
     //       set { rateList[index] = value; }
     //   }





        public void Calculate()
        {
            averageRate = (float) rateList.Average();
        }

    }
}
