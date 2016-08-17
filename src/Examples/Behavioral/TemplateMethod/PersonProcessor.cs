using System;
using System.Collections.Generic;

namespace Examples.Behavioral.TemplateMethod
{
    public abstract class PersonProcessor
    {
        public void Process()
        {
            Console.WriteLine("Processing persons...");

            Console.WriteLine($"\nPerson Processing: {GetProcessingTitle()}");

            foreach (Person person in GetPersons())
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
}