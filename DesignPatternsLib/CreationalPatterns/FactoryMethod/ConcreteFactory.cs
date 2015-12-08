using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.FactoryMethod
{
    public class ConcreteFactory : FactoryBase
    {
        public override ProductBase ProductFactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
