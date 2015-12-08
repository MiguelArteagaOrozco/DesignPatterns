using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.ChainOfResponsability
{
    public abstract class HandlerBase
    {
        protected HandlerBase _succesor;

        public void SetSucessor(HandlerBase handler)
        {
            _succesor = handler;
        }

        public abstract string RequestHandler(int request);
    }
}
