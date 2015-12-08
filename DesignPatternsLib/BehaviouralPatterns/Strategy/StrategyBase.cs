using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Strategy
{
    public abstract class StrategyBase
    {
        public abstract int Algorithm(int numA, int numB);
    }
}
