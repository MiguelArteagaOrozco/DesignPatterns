using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Strategy
{
    public class Multiplicacion : StrategyBase
    {
        public override int Algorithm(int numA, int numB)
        {
            return numA * numB;
        }
    }
}
