using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.ChainOfResponsability
{
    public class HandlerB : HandlerBase
    {
        public override string RequestHandler(int request)
        {
            if (request == 2) return "HandlerB = 2";

            else if (_succesor != null)
                return _succesor.RequestHandler(request);

            return string.Empty;
        }
    }
}
