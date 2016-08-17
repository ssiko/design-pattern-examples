using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Creational.Factory
{
    public class FactoryDemo : DemoBase
    {
        protected override void DoRun()
        {
            Console.WriteLine("By running this application you are using the factory pattern. The demo is chosen using the factory method. Try passing the 'numeric' arg to the application for the other method of selection");
        }
    }
}
