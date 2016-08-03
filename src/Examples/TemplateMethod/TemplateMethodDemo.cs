using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.TemplateMethod
{
    public static class TemplateMethodDemo
    {
        public static void Run()
        {
            PersonProcessor processor = new GitHubContributingPersonProcessor();
            processor.Process();

            Console.WriteLine("\n\nPress <ENTER> key to continue...");
            Console.ReadLine();
        }
    }
}
