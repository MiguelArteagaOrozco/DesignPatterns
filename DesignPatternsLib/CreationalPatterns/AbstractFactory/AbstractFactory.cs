using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.AbstractFactory
{
    abstract public class AbstractFactory
    {
        abstract public AbstractProductA CreateProductA();
        abstract public AbstractProductB CreateProductB();
    }
}
