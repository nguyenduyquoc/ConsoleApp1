using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Session4
{
    public delegate void PrintString(string s);

    internal class DemoDelegate
    {
        public void ShowMessage(string msg)
        {
            Console.WriteLine("show info: " + msg);
        }

        public static void Alert(string str)
        {
            Console.WriteLine("Alert : " + str);
        }
    }
}
