using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class Sony_Laptop : ILaptop
    {
        public void ShowModel()
        {
            Console.WriteLine("I am Sony Laptop");
        }
    }
}
