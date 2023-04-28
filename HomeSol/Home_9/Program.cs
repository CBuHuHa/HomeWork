using System;
using Home_9;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = PersonGenerator.GenList(10);

            foreach (Person person in people)
            {
                person.ShowInfo();
            }
        }
    }
}