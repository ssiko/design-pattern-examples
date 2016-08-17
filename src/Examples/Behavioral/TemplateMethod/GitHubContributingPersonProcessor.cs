using System.Collections.Generic;

namespace Examples.Behavioral.TemplateMethod
{
    public class GitHubContributingPersonProcessor : PersonProcessor
    {
        protected override string GetProcessingTitle()
        {
            return "GitHub Contributors to the Design Patterns repo";
        }

        protected override IEnumerable<Person> GetPersons()
        {
            yield return new Person { Name = "James", Title = "Architect" };
            yield return new Person { Name = "Hiro", Title = "Senior Developer" };
            yield return new Person { Name = "Stan", Title = "Senior Developer" };
            yield return new Person { Name = "Steve", Title = "Senior Developer" };
            yield return new Person { Name = "Chris", Title = "Senior Developer" };
            yield return new Person { Name = "Purvin", Title = "Senior Developer" };
        }

        protected override bool PersonMeetsCriteria(Person person)
        {
            return person.Name.Equals("James") || person.Name.Equals("Steve");
        }
    }
}