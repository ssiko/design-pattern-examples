using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Factory
{
    public abstract class DemoCreator
    {
        public abstract DemoBase Create(string demo);

        public List<DemoBase> Demoes = new List<DemoBase>
        {
            new Builder.BuilderDemo(),
            new Factory.FactoryDemo(),
            new Behavioral.Strategy.StrategyDemo(),
            new Behavioral.TemplateMethod.TemplateMethodDemo(),
            new Behavioral.Visitor.VisitorDemo(),
            new Structural.Bridge.BridgeDemo()
        };

        public abstract void PrintDemoes();
    }
}
