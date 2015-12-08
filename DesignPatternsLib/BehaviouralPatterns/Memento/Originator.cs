using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Memento
{
    public class Originator
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
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void RestoreMemento(Memento memento)
        {
            State = memento.GetState();
        }
    }
}
