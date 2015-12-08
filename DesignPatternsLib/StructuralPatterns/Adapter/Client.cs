using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.StructuralPatterns.Adapter
{
    public class Client
    {
        ITarget _adapter;
        public Client(ITarget adapter)
        {
            _adapter = adapter;
        }

        public string GetValue()
        {
            return _adapter.MethodA();
        }
    }
}
