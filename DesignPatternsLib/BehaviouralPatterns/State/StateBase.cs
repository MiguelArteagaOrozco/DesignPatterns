using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.State
{
    public abstract class StateBase
    {
        public abstract void Handle(Context context);
    }
}
