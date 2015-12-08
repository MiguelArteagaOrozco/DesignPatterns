using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Command
{
    public class Invoker
    {
        public CommandBase command { get; set; }
        public string ExecuteCommand()
        {
            if (command != null)
                return command.Execute();
            return string.Empty;
        }
    }
}
