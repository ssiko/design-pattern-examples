using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples
{
    public abstract class DemoBase
    {
        public abstract void Run();

        public void WaitForUser()
        {
            Console.WriteLine("\n\nPress <ENTER> key to continue...");
            Console.ReadLine();
        }
    }
}
