using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public interface ITarget
    {
        List<string> GetProducts();
    }
}
