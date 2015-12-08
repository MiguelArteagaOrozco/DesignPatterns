using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Mediator
{
    public abstract class MediatorBase
    {
        public abstract void SendMesage(ColleagueBase caller);
    }
}
