using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.State
{
    public class Context
    {
        public StateBase State { get; set; }


        public void Request()
        {
            this.State.Handle(this);
        }
    }
}
