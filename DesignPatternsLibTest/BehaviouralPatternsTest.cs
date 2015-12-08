using DesignPatternsLib.BehaviouralPatterns.ChainOfResponsability;
using DesignPatternsLib.BehaviouralPatterns.Command;
using DesignPatternsLib.BehaviouralPatterns.Interpreter;
using DesignPatternsLib.BehaviouralPatterns.Mediator;
using DesignPatternsLib.BehaviouralPatterns.Memento;
using DesignPatternsLib.BehaviouralPatterns.Observer;
using DesignPatternsLib.BehaviouralPatterns.Strategy;
using DesignPatternsLib.BehaviouralPatterns.TemplateMethod;
using DesignPatternsLib.BehaviouralPatterns.Visitor;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLibTest
{
    [TestClass]
    public class BehaviouralPatternsTest
    {
        [TestMethod]
        public void ChainOfResponsability_Test()
        {
            var handlerA = new HandlerA();
            var handlerB = new HandlerB();

            handlerA.SetSucessor(handlerB);
            handlerB.SetSucessor(handlerA);

            var resultA = handlerA.RequestHandler(2);
            var resultB = handlerB.RequestHandler(1);

            Assert.IsTrue(resultA.Contains("2"));
            Assert.IsTrue(resultB.Contains("1"));

        }

        [TestMethod]
        public void Command_Test()
        {
            var command = new CommandA(new Receiver()); // Receiver contains the action
            command.Parameter = "hola!!";

            var invoker = new Invoker();
            invoker.command = command;
            var result = invoker.ExecuteCommand();

            Assert.IsTrue(result.Contains(command.Parameter) && result.Length > command.Parameter.Length);
        }
        [TestMethod]
        public void Interpereter_Test()
        {
            var context = new Context("hello");

            var terminalA = new TerminalExpression();
            var terminalB = new TerminalExpression();

            var nonTerminal = new NonTerminalExpression();

            nonTerminal.SubExpressionA = terminalA;
            nonTerminal.SubExpressionB = terminalB;

            var result = nonTerminal.Interpret(context);

            Assert.IsTrue(result.Contains(context.Name));
        }
        [TestMethod]
        public void Mediator_Test()
        {
            var mediator = new Mediator();
            var A = new Colleague(mediator);
            var B = new Colleague(mediator);

            mediator.colleagueA = A;
            mediator.colleagueB = B;

            A.Message = "Mike";
            A.Send();

            var lastMsg = B.LastMessage;

            Assert.IsTrue(lastMsg.Contains(A.Message));
        }

        [TestMethod]
        public void Memento_Test()
        {
            var originator = new Originator();

            originator.State = "A";

            var memento = originator.CreateMemento();

            originator.State = "B";

            originator.RestoreMemento(memento);

            Assert.IsTrue(originator.State == "A");
        }
        [TestMethod]
        public void Observer_Test()
        {
            var sub = new Subject();
            var obsA = new ObserverA(sub);
            var obsB = new ObserverB(sub);

            sub.State = "Mike";

            var resA = obsA.State;
            var resB = obsB.State;

            Assert.IsTrue(resA.Contains(sub.State));
            Assert.IsTrue(resB.Contains(sub.State));
        }
        [TestMethod]
        public void State_Test()
        {
            var context = new DesignPatternsLib.BehaviouralPatterns.State.Context();

            context.State = new DesignPatternsLib.BehaviouralPatterns.State.StateA();

            context.Request();

            Assert.IsNotNull(context.State as DesignPatternsLib.BehaviouralPatterns.State.StateB);

            context.Request();
        
            Assert.IsNotNull(context.State as DesignPatternsLib.BehaviouralPatterns.State.StateA);
        }
        [TestMethod]
        public void Strategy_Test()
        {
            var client = new StrategyClient();

            client.NumA = 5;
            client.NumB = 5;

            client.Strategy = new Suma();

            var res = client.CallAlgorithm();

            Assert.IsTrue(res == 10);

            client.Strategy = new Multiplicacion();

            res = client.CallAlgorithm();

            Assert.IsTrue(res == 25);
        }

        [TestMethod]
        public void TemplateMethod_Test()
        {
            var alg = new AlgorithmA(2, 3);

            var res = alg.TemplateMethod();

            Assert.AreEqual(res, 8);
        }

        [TestMethod]
        public void Visitor_Test()
        {
            var structure = new Structure();
            var e1 = new Element01() { State=0};
            var e2 = new Element02() { State =1};
            var v1 = new VisitorA();
            var v2 = new VisitorB();

            structure.Elements.Add(e1);
            structure.Elements.Add(e2);

            structure.Accept(v1);

            Assert.IsTrue(e1.State == 2 && e2.State == 3);

            structure.Accept(v2);

            Assert.IsTrue(e1.State == 12 && e2.State == 13);
        }
    }
}
