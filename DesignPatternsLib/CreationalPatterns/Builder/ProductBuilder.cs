using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Builder
{
    public class ProductBuilder : Builder
    {
        Product _product = new Product();
        public override Builder BuildPart1()
        {
            _product.Part1 = "parte 1";
            return this;
        }

        public override Builder BuildPart2()
        {
            _product.Part2 = "parte 2";
            return this;
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}
