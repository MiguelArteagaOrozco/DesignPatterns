using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.State
{
    public class StateA : StateBase
    {
        public override void Handle(Context context)
        {
            context.State = new StateB();
        }
    }
}
