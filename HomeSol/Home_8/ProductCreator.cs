using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_8
{
    public class ProductCreator
    {
        public static List<Product> CreateRation(int count)
        {
            string[] food = { "Banana", "Ham", "Beef", "Pear", "Potato", "Shrimp", "Chicken", "Butter", "Carrot", "Tomato", "Pork", "Spaghetti", "Bread", "Chocolate" };
            int minCal = 100;
            int maxCal = 300;
            List<Product> list = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                Random random = new Random();
                Product product = new Product(food[random.Next(food.Length)].ToString(), random.Next(minCal, maxCal));
                list.Add(product);
            }

            return list;
        }
    }
}
