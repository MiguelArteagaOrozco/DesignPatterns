using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        AbstractFactory _factory;
        public AbstractProductA ProductA { get; private set; }
        public AbstractProductB ProductB { get; private set; }

        public Client(AbstractFactory factory)
        {
            _factory = factory;

            ProductA = _factory.CreateProductA();
            ProductB = _factory.CreateProductB();
        }

    }
}
