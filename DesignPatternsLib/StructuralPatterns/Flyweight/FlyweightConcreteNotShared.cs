using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Flyweight
{
    public class FlyweightConcreteNotShared : FlyweightBase
    {
        public override string StateFulOperation()
        {
            return "FlyweightConcreteNotShared";
        }
    }
}
