using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Interpreter
{
    public class NonTerminalExpression : ExpressionBase
    {
        public ExpressionBase SubExpressionA { get; set; }
        public ExpressionBase SubExpressionB { get; set; }

        public override string Interpret(Context context)
        {
            return SubExpressionA.Interpret(context) + SubExpressionB.Interpret(context);
        }
    }
}
