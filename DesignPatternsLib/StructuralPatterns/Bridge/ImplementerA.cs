using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Bridge
{
    public class ImplementerA : ImplementerBase
    {
        public override string OperationImplementation()
        {
            return "ImplementerA";
        }
    }
}
