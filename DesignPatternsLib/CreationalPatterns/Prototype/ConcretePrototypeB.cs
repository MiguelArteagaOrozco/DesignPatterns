using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Prototype
{
    public class ConcretePrototypeB : Prototype
    {
        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
