using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class RationCreator
    {
        public static Dictionary<Week, List<Product>> GetRation()
        {
            Random rand = new Random();
            int minCount = 3;
            int maxCount = 7;

            Dictionary<Week, List<Product>> ration = new Dictionary<Week, List<Product>>();

            foreach (Week item in Enum.GetValues(typeof(Week)))
            {
                ration.Add(item, ProductCreator.CreateRation(rand.Next(minCount, maxCount)));
            }

            return ration;
        }

        public static void VeiwRation(Dictionary<Week, List<Product>> ration)
        {
            foreach (var item in ration)
            {
                Console.WriteLine(item.Key.ToString());

                foreach (var product in item.Value)
                {
                    string name = product.Name;
                    int cal = product.Calories;

                    Console.WriteLine($" {name} : {cal}");
                }
            }
        }
    }
}