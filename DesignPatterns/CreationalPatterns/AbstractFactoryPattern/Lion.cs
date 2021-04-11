using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
