using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.TemplateMethod
{
    public class AlgorithmA : AlgorithmBase
    {
        public AlgorithmA(int numA, int numB):base(numA, numB) { }

        public override void Step1()
        {
            _result = _numA + _numB;
        }

        public override void Step2()
        {
            _result = _result - 1;
        }

        public override void Step3()
        {
            _result = _result * 2;
        }
    }
}
