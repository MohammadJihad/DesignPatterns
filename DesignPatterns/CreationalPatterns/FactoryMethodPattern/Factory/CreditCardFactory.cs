using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethodPattern
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    public abstract class CreditCardFactory
    {
        /// <summary>
        /// FactoryMethod
        /// </summary>
        /// <returns></returns>
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return MakeProduct();
        }
    }
}
