using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_9
{
    internal class PersonGenerator
    {
        private static string[] names = new string[] { "Francis", "Caroline", "Harold", "Alise", "Emily", "Nancy", "Vanessa", "Roger", "Dennis", "Edward", "Anna", "Lucas", "Lily", "Martin", "Rachel" };
        private static int minRandomAge = 10;
        private static int maxRandomAge = 65;
        private static int minRandomSalary = 10;
        private static int maxRandomalary = 2000;

        public static List<Person> GenList(int count)
        {
            Random random = new Random();

            List<Person> people = new List<Person>();

            for (int i = 0; i <= count; i++)
            {
                Person person = new Person(names[random.Next(names.Length)], random.Next(minRandomAge, maxRandomAge), random.Next(minRandomSalary, maxRandomalary));
                people.Add(person);
            }

            return people;
        }
    }
}
