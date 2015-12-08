using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using DesignPatternsLib.CreationalPatterns.AbstractFactory;
using DesignPatternsLib.CreationalPatterns.Builder;
using DesignPatternsLib.CreationalPatterns.FactoryMethod;
using DesignPatternsLib.CreationalPatterns.Prototype;
using DesignPatternsLib.CreationalPatterns.Singleton;

namespace DesignPatternsLibTest
{
    [TestClass]
    public class CreationalPaternsTest
    {
        [TestMethod]
        public void AbstractFactory_CheckCorrectInstances()
        {
            var factoryA = new ConcreteFactoryA();
            var _clientA = new Client(factoryA);

            var factoryB = new ConcreteFactoryB();
            var _clientB = new Client(factoryB);

            var prodA1 = _clientA.ProductA;
            var prodB1 = _clientA.ProductB;

            var prodA2 = _clientB.ProductA;
            var prodB2 = _clientB.ProductB;

            Assert.IsTrue((prodA1 as ConcreteProductA1) != null, "prodA1 incorrecto");
            Assert.IsTrue((prodB1 as ConcreteProductB1) != null, "prodA1 incorrecto");
            Assert.IsTrue((prodA2 as ConcreteProductA2) != null, "prodA1 incorrecto");
            Assert.IsTrue((prodB2 as ConcreteProductB2) != null, "prodA1 incorrecto");

        }

        [TestMethod]
        public void Builder_CheckProductContruction()
        {
            var _director = new Director(new ProductBuilder());

            var product = _director.BuildProduct();

            Assert.IsTrue(!string.IsNullOrEmpty(product.Part1));
            Assert.IsTrue(!string.IsNullOrEmpty(product.Part2));
        }

        [TestMethod]
        public void FactoryMethod_CheckInstance()
        {
            var fm = new ConcreteFactory();
            var prod = fm.ProductFactoryMethod();

            Assert.IsFalse(prod as ConcreteProduct == null);
        }

        [TestMethod]
        public void Prototype_CheckClone()
        {
            var concreteB = new ConcretePrototypeB() { Name = "A" };

            var concreteA = concreteB.Clone();

            Assert.IsTrue(concreteA.Name == concreteB.Name);
        }

        [TestMethod]
        public void SingletonTest()
        {
            var ref1 = Singleton.Instance;
            ref1.StateA = true;

            var ref2 = Singleton.Instance;

            Assert.IsTrue(ref1.StateA == ref2.StateA);
        }
    }
}
