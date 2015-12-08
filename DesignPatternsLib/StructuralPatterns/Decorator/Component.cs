using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Decorator
{
    public class Component : ComponentBase
    {
        public override string Operation()
        {
            return "component";
        }
    }
}
