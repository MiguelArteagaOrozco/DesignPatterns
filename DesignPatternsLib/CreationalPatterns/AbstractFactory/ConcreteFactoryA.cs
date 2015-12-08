using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.AbstractFactory
{
    public class ConcreteFactoryA : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
