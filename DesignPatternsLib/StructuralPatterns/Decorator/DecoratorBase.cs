using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Decorator
{
    public abstract class DecoratorBase:ComponentBase
    {
        private ComponentBase _component;
        public DecoratorBase(ComponentBase component)
        {
            _component = component;
        }
        public override string Operation()
        {
            return _component.Operation();
        }
    }
}
