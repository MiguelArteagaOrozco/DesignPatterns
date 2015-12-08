using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Mediator
{
    public class Colleague : ColleagueBase
    {
        public Colleague(MediatorBase mediator) : base(mediator) { }
        public string LastMessage { get; set; }

        public override string Recv(string msg)
        {
            LastMessage = msg;
            return msg;
        }

        public override void Send()
        {
            _mediator.SendMesage(this);
        }
    }
}
