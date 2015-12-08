using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Facade
{
    public class Facade
    {
        ClassA classA = new ClassA();
        ClassB classB = new ClassB();
        ClassC classC = new ClassC();

        public string PerformAction()
        {
            string resA = classA.MethodA();
            string resB = classB.MethodB();

            string resC = classC.MethodC(resA, resB);

            return resC;
        }
    }

    
}
