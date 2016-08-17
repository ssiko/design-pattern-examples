using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Examples.Creational.Factory
{
    public class NumericDemoCreator : DemoCreator
    {

        public override DemoBase Create(string demo)
        {
            int demoIndex;
            DemoBase demoToRun = null;

            if (int.TryParse(demo, out demoIndex))
            {
                demoToRun = Demoes.ElementAtOrDefault(demoIndex - 1);
            }

            if (demoToRun == null)
            {
                Console.Write("Type not found please enter another type: ");
                return Create(Console.ReadLine());
            }
            else
                return demoToRun;
        }

        public override void PrintDemoes()
        {
            int index = 1;
            foreach (DemoBase demo in Demoes)
            {
                Console.WriteLine($"{index} - {demo.GetType()}");
                index++;
            }
        }

    }
}
