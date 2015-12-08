using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Bridge
{
    public class RedefinedAbstraction: Abstraction
    {
        public override string Operation()
        {
            return base.Operation()+ " + redefined";
        }
    }
}
