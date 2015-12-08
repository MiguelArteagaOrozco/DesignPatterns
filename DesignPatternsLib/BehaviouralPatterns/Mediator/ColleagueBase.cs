using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Mediator
{
    public abstract class ColleagueBase
    {
        public string Message { get; set; }

        protected MediatorBase _mediator;
        public ColleagueBase(MediatorBase mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send();
        public abstract string Recv(string msg);
    }
}
