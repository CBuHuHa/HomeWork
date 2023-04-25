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
        }

        public void CheckRation(Dictionary<Week, List<Product>> ration)
        {
            foreach (List<Product> list in ration.Values)
            {
                int sum = 0;

                foreach (Product product in list)
                {
                    sum += product.Calories;
                }

                while (sum > this.MaxNumberOfCalories)
                {
                    sum -= list[list.Count - 1].Calories;
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}