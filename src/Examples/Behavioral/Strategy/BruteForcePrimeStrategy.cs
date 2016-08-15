using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Strategy
{
    public class BruteForcePrimeStrategy : IPrimeStrategy
    {
        public bool IsPrime(int number)
        {
            //check evenness
            if ((number & 1) == 0)
            {
                return number == 2;
            }
            //check for squares and primality
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return number != 1;
        }
    }
}
