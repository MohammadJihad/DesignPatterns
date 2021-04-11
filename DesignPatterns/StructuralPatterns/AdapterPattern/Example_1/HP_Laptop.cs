using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class HP_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am HP Laptiop");
        }
    }
}
