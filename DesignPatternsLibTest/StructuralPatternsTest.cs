using DesignPatternsLib.StructuralPatterns.Adapter;
using DesignPatternsLib.StructuralPatterns.Bridge;
using DesignPatternsLib.StructuralPatterns.Composite;
using DesignPatternsLib.StructuralPatterns.Decorator;
using DesignPatternsLib.StructuralPatterns.Proxy;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibTest
{
    [TestClass]
    public class StructuralPatternsTest
    {
        [TestMethod]
        public void Adapter_Test()
        {
            var adaptee = new Adaptee() { state = true };

            var client = new Client(new Adapter(adaptee));

            var result = client.GetValue();

            Assert.AreEqual(adaptee.state.ToString(), result);
        }

        [TestMethod]
        public void Bridge_Test()
        {
            var abs = new Abstraction();
            var implementer = new ImplementerA();
            var absRedefined = new RedefinedAbstraction();

            abs.Implementer = implementer;
            absRedefined.Implementer = implementer;

            Assert.AreNotEqual(abs.Operation(), absRedefined.Operation());
        }
        [TestMethod]
        public void Composite_Test()
        {
            var composite = new Composite();
            composite.AddChild(new DesignPatternsLib.StructuralPatterns.Composite.Component());

            var subcomposite = new Composite();
            subcomposite.AddChild(new DesignPatternsLib.StructuralPatterns.Composite.Component());
            subcomposite.AddChild(new Leaf());

            composite.AddChild(subcomposite);

            composite.AddChild(new Composite());
            composite.AddChild(new Leaf());

            int countChild = 0;
            int countSubChild = 0;

            foreach (var item in composite)
            {
                if (item as Composite != null)
                {
                    foreach (var item2 in item as Composite)
                    {
                        countSubChild++;
                    }
                }
                
                countChild++;
            }

            Assert.AreEqual(countChild, 4);
            Assert.AreEqual(countSubChild, 2);
        }

        [TestMethod]
        public void Decorator_Test()
        {
            var comp = new DesignPatternsLib.StructuralPatterns.Decorator.Component();
            var resA = comp.Operation();

            var decorator = new Decorator(comp);

            var resB = decorator.Operation();

            Assert.AreEqual(resA + "_decorated", resB);
        }

        [TestMethod]
        public void Proxy_Test()
        {
            var proxy = new Proxy();
            RealSubject realSubject = new RealSubject();

            var resProxy = proxy.PerformAction();
            var resRealSubject = realSubject.PerformAction();

            Assert.AreEqual(resProxy, resRealSubject);
        }
    }
}
