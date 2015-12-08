using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Strategy
{
    public class StrategyClient
    {
        public StrategyBase Strategy { get; set; }
        public int NumA { get; set; }
        public int NumB { get; set; }

        public int CallAlgorithm()
        {
            if (Strategy == null) throw new Exception("set strategy please");
            return Strategy.Algorithm(NumA, NumB);
        }
    }
}
