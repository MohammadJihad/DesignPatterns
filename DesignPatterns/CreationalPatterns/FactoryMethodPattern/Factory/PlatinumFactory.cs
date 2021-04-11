using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern.Factory
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class PlatinumFactory : CreditCardFactory
    {
        /// <summary>
        /// FactoryMethod
        /// </summary>
        /// <returns></returns>
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
