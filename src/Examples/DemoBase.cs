using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples
{
    public abstract class DemoBase
    {
        protected abstract void DoRun();

        public bool Run()
        {
            DoRun();
            return WaitForUser();
        }

        public bool WaitForUser()
        {
            Console.Write("\n\nDemo Complete...Run another? (y/n)");
            string result = Console.ReadLine().ToLower();
            return result == "y";
        }
    }
}
