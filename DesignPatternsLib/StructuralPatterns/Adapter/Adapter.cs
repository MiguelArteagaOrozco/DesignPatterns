using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Adapter
{
    public class Adapter : ITarget
    {
        Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string MethodA()
        {
            return _adaptee.MethodB().ToString();
        }
    }
}
