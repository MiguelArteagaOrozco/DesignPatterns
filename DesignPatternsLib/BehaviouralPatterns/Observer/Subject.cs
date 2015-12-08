using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Observer
{
    public class Subject:SubjectBase
    {
        private string _state;

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
                Notify();
            }
        }

        public override string GetState()
        {
            return State;
        }
    }
}
