using System;
using Home_9;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PersonGenerator.GenList(10);

            //var peopleWithNames = from person in people
            //                      where person.Name.StartsWith("A")
            //                      select person;

            var peopleWithNames = people.Where(person => person.Name.StartsWith("A"));

            foreach (var person in peopleWithNames)
            {
                person.ShowInfo();
            }
        }
    }
}