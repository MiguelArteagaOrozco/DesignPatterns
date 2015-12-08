using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Command
{
    public class Receiver
    {
        public string Action(string parameter)
        {
            return string.Format("{0}-{1}", "Action:", parameter);
        }
    }
}
