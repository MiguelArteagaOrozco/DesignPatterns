using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, FlyweightBase> _flyweights = new Dictionary<string, FlyweightBase>();

        public FlyweightBase GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
                _flyweights.Add(key, new FlyweightConcrete());

            return _flyweights[key];
        }
    }
}
