using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.TemplateMethod
{
    public abstract class AlgorithmBase
    {
        protected int _numA;
        protected int _numB;
        protected int _result = 0;
        public AlgorithmBase(int numA, int numB)
        {
            _numA = numA;
            _numB = numB;
        }

        public int TemplateMethod()
        {
            Step1();
            Step2();
            Step3();

            return _result;
        }

        public abstract void Step3();
        public abstract void Step2();
        public abstract void Step1();
    }
}
