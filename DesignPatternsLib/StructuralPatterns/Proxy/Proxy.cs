using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Proxy
{
    public class Proxy : SubjectBase
    {
        private RealSubject subject;
        public override string PerformAction()
        {
            if (subject == null) subject = new RealSubject();

            return subject.PerformAction();
        }
    }
}
