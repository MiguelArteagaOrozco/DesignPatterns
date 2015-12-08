using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Visitor
{
    public class VisitorA : VisitorBase
    {
        public override void Visit(Element02 element)
        {
            element.State += 2;
        }

        public override void Visit(Element01 element)
        {
            element.State += 2;
        }
    }
}
