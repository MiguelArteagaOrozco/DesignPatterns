using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Interpreter
{
    public abstract class ExpressionBase
    {
        public abstract string Interpret(Context context);
    }
}
