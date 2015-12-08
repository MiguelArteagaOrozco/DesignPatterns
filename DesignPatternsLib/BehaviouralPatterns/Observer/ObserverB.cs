using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Observer
{
    public class ObserverB : ObserverBase
    {
        public ObserverB(SubjectBase subject) : base(subject) { }

        public string State { get; set; }

        public override void Update()
        {
            State = this._subject.GetState() + "+B";
        }
    }
}
