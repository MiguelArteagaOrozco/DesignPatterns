using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Mediator
{
    public class Mediator:MediatorBase
    {
        public ColleagueBase colleagueA { get; set; }
        public ColleagueBase colleagueB { get; set; }

        public override void SendMesage(ColleagueBase caller)
        {
            if (caller == colleagueA)
                colleagueB.Recv("mesage for B: "+caller.Message);
            else
                colleagueA.Recv("mesage for A: " + caller.Message);
        }
    }
}
