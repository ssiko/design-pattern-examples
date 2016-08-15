using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Strategy
{
    public class StrategyDemo : DemoBase
    {
        protected override void DoRun()
        {
            PrimeTool tool = new PrimeTool(new SieveOfEratosthenesPrimeStrategy(100));
            
            TestPrimes(tool);


            tool.Strategy = new BruteForcePrimeStrategy();
            TestPrimes(tool);


            WaitForUser();
        }

        private void TestPrimes(PrimeTool tool)
        {
            Console.WriteLine($"Checking first 100 primes using {tool.Strategy.GetType()}");
            for (int x = 0; x <= 100; x++)
            {
                tool.CheckPrime(x);
            }
        }

    }
}
