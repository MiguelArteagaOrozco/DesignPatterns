using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Visitor
{
    public class Structure
    {
        public List<ElementBase> Elements { get; set; }

        public Structure()
        {
            Elements = new List<ElementBase>();
        }

        public void Accept(VisitorBase visitor)
        {
            foreach (var e in Elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
