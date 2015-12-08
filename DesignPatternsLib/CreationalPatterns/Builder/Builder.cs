using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Builder
{
    public abstract class Builder
    {
        public abstract Builder BuildPart1();
        public abstract Builder BuildPart2();

        public abstract Product GetProduct();
    }
}
