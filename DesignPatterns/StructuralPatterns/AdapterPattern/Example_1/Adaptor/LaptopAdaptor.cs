using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class LaptopAdaptor : Person, ILaptop
    {
        public void ShowModel() { }
        public static void ShowModel(ILaptop obj)
        {
            obj.ShowModel();
        }
    }
}
