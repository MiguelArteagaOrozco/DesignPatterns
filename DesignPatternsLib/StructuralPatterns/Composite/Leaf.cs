using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Composite
{
    public class Leaf: Component
    {
        public override string Operation()
        {
            return "leaf";
        }
    }
}
