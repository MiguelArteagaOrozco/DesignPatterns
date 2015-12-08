using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Adapter
{
    public class Adaptee
    {
        public bool state { get; set; }
        public bool MethodB()
        {
            return state;
        }
    }
}
