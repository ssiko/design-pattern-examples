using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Behavioral.TemplateMethod
{
    public abstract class PersonProcessor
    {
        public void Process()
        {
            Console.WriteLine("Processing persons...");

            Console.WriteLine($"\nPerson Processing: {GetProcessingTitle()}");

            foreach(Person person in GetPersons())
            {
                if (PersonMeetsCriteria(person))
                {
                    Console.WriteLine($"\t{person.Name} HAS met the criteria.");
                }
                else
                {
                    Console.WriteLine($"\t{person.Name} HAS NOT met the criteria.");
                }
            }
        }

        protected abstract string GetProcessingTitle();
        
        protected abstract IEnumerable<Person> GetPersons();

        protected abstract bool PersonMeetsCriteria(Person person);
    }

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
