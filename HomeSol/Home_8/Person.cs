using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class Person
    {
        public string Name { get; set; }
        public int MaxNumberOfCalories { get; set; }

        public Person(string name, int maxNumberOfCalories)
        {
            Name = name;
            MaxNumberOfCalories = maxNumberOfCalories;

            Console.WriteLine($"{Name} : {MaxNumberOfCalories}");
        }
    }
}