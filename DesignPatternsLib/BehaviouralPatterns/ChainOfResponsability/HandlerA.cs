using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.ChainOfResponsability
{
    public class HandlerA : HandlerBase
    {
        public override string RequestHandler(int request)
        {
            if (request == 1) return "HandlerA = 1";

            else if (_succesor != null)
                return _succesor.RequestHandler(request);

            return string.Empty;
        }
    }
}
