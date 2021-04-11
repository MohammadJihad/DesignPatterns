using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// Adaptee
    /// </summary>
    public class Person
    {
        public void SwitchOn(ILaptop obj)
        {
            LaptopAdaptor.ShowModel(obj);
        }
    }
}
