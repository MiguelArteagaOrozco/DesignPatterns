using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Interpreter
{
    public class TerminalExpression : ExpressionBase
    {
        public override string Interpret(Context context)
        {
            return context.Name;
        }
    }
}
