using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLib.CreationalPatterns.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _lookThis = new object();

        public bool StateA { get; set; }

        public static Singleton Instance
        {
            get
            {
                lock (_lookThis)
                {
                    if (_instance == null)
                        _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
