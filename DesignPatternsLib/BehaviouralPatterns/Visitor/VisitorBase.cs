using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Visitor
{
    public abstract class VisitorBase
    {
        public abstract void Visit(Element01 element);
        public abstract void Visit(Element02 element);
    }
}
