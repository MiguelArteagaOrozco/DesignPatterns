using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Command
{
    public class CommandA : CommandBase
    {
        public CommandA(Receiver receiver) : base(receiver) { }
        public string Parameter { get; set; }

        public override string Execute()
        {
            return _receiver.Action(Parameter);
        }
    }
}
