using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Strategy
{
    public class PrimeTool
    {
        public IPrimeStrategy Strategy { get; set; }

        public PrimeTool(IPrimeStrategy strategy)
        {
            Strategy = strategy;
        }

        public void CheckPrime(int number)
        {            
            Console.WriteLine($"{number} is {(Strategy.IsPrime(number) ? String.Empty : "not ")}prime");
        }
    }
}
