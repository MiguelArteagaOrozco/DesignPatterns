using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.BehaviouralPatterns.Observer
{
    public abstract class ObserverBase
    {
        protected SubjectBase _subject;

        public ObserverBase(SubjectBase subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public abstract void Update();
    }
}
