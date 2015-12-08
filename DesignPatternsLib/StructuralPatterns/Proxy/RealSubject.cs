using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Proxy
{
    public class RealSubject : SubjectBase
    {
        public override string PerformAction()
        {
            return "RealSubject";
        }
    }
}
