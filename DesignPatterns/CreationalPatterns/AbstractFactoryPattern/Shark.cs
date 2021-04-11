using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}
