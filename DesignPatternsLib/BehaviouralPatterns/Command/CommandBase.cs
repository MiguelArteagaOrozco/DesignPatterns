using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Command
{
    public abstract class CommandBase
    {
        protected Receiver _receiver;
        public CommandBase(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract string Execute();
    }
}
