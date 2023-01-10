using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Session4
{
    internal class Button
    {

        public event PrintString Action;
        public Button(PrintString functionName) 
        {
            Action += functionName;
        }

        public void ClickAction()
        {
            Action("click here");
        }
    }
}
