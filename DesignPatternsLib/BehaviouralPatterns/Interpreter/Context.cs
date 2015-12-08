using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Interpreter
{
    public class Context
    {
        public string Name { get; set; }

        public Context(string name)
        {
            Name = name;
        }
    }
}
