﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Decorator
{
    public class Decorator : DecoratorBase
    {
        public Decorator(ComponentBase component) : base(component)
        {
        }

        public override string Operation()
        {
            return base.Operation() + "_decorated";
        }
    }
}
