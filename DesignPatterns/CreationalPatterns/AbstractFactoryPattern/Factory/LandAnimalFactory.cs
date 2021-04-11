using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.AbstractFactoryPattern.Factory
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}
