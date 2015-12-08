using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Composite
{
    public class Component
    {
        public virtual string Operation()
        {
            return "component";
        }
    }
}
