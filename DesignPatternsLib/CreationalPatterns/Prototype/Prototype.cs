using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Prototype
{
    public abstract class Prototype
    {
        public string Name { get; set; }

        public abstract Prototype Clone();
    }
}
