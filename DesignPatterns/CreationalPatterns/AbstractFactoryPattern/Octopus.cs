using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
