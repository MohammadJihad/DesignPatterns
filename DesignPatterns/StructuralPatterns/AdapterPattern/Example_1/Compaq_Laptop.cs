using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class Compaq_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am Compaq Laptop");
        }
    }
}
