namespace Examples.Behavioral.TemplateMethod
{
    public class TemplateMethodDemo : DemoBase
    {
        protected override void DoRun()
        {
            PersonProcessor processor = new GitHubContributingPersonProcessor();
            processor.Process();
        }
    }
}