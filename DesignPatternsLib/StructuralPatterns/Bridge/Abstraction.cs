using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Bridge
{
    public class Abstraction
    {
        public ImplementerBase Implementer{ get; set; }

        public virtual string Operation()
        {
            return Implementer.OperationImplementation();
        }
    }
}
