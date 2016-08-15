using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.TemplateMethod
{
    public class TemplateMethodDemo : DemoBase
    {
        public override void Run()
        {
            PersonProcessor processor = new GitHubContributingPersonProcessor();
            processor.Process();

            WaitForUser();
        }
    }
}
