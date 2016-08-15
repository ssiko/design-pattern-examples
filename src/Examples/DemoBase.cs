using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples
{
    public abstract class DemoBase
    {
        protected abstract void DoRun();

        public void Run()
        {
            DoRun();
        }

        public void WaitForUser()
        {
            Console.WriteLine("\n\nPress <ENTER> key to continue...");
            Console.ReadLine();
        }
    }
}
