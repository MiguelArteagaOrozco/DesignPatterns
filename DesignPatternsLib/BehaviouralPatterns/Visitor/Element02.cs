using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Visitor
{
    public class Element02 : ElementBase
    {
        public int State  { get; set; }
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }
}
