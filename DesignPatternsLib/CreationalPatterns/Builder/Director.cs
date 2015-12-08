using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Builder
{
    public class Director
    {
        Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public Product BuildProduct()
        {
            _builder.BuildPart1();
            _builder.BuildPart2();

            return _builder.GetProduct();
        }
    }
}
