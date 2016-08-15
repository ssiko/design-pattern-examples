using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.TemplateMethod
{
    public class TemplateMethodDemo : DemoBase
    {
        protected override void DoRun()
        {
            PersonProcessor processor = new GitHubContributingPersonProcessor();
            processor.Process();

            WaitForUser();
        }
    }
}
