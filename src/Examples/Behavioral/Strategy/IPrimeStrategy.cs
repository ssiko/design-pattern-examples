using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.Strategy
{
    public interface IPrimeStrategy
    {
        bool IsPrime(int number);
    }
}
