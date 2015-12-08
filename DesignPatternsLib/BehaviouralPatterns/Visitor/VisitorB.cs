using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Visitor
{
    public class VisitorB : VisitorBase
    {
        public override void Visit(Element02 element)
        {
            element.State += 10;
        }

        public override void Visit(Element01 element)
        {
            element.State += 10;
        }
    }
}
