using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    /// <summary>
    /// This is an "object adapter" as the adapter uses object composition
    /// </summary>
    class VendorAdapter : ITarget
    {
        public List<string> GetProducts()
        {
            VendorAdaptee adaptee = new VendorAdaptee();
            return adaptee.GetListOfProducts();
        }
    }

    /// <summary>
    /// This is an "class adapter" as the adapter uses inheritance
    /// </summary>
    //class VendorAdapter : VendorAdaptee, ITarget
    //{
    //    public List<string> GetProducts()
    //    {
    //        return GetListOfProducts();
    //    }
    //}
}
