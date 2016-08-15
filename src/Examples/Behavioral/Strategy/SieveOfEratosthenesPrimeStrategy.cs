using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Strategy
{
    public class SieveOfEratosthenesPrimeStrategy : IPrimeStrategy
    {
        List<int> Primes { get; set; }
        public SieveOfEratosthenesPrimeStrategy(int highPrime)
        {
            Dictionary<int, bool> sieve = new Dictionary<int, bool>();
            for (int x = 2; x <= highPrime; x++)
            {
                sieve.Add(x, true);
            }
            int counter = 0;

            //made this 24 so it doesn't run forever. not perfect feel free to improve this algo, will become unreliable on large sets.
            while (counter <= 24)
            {
                int value = sieve.Where(p => p.Value).Select(p => p.Key).ElementAt(counter);
                for (int x = value * 2; x <= highPrime; x += value)
                {
                    sieve[x] = false;
                }
                counter++;
            }
            Primes = sieve.Where(p => p.Value).Select(p => p.Key).ToList();
        }

        public bool IsPrime(int number)
        {
            return Primes.Contains(number);
        }
    }
}
