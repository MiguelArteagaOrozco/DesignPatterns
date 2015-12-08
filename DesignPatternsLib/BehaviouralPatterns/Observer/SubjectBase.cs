using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Observer
{
    public abstract class SubjectBase
    {
        public SubjectBase()
        {
            Observers = new List<ObserverBase>();
        }

        public List<ObserverBase> Observers { get; set; }

        public void Notify()
        {
            if(this.Observers != null)
                foreach (var o in Observers)
                {
                    o.Update();
                }
        }

        public abstract string GetState();

        public void Attach(ObserverBase observer)
        {
            Observers.Add(observer);
        }
        public void Dettach(ObserverBase observer)
        {
            Observers.Remove(observer);
        }
    }
}
