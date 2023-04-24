using Home_8;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCreator creator = new ProductCreator();

            Dictionary<Week, List<Product>> ration = new Dictionary<Week, List<Product>>()
            {
                { Week.Monday, creator.CreateRation() },
                { Week.Tuesday, creator.CreateRation() },
                { Week.Wednesday, creator.CreateRation() },
                { Week.Thursday, creator.CreateRation() },
                { Week.Friday, creator.CreateRation() },
                { Week.Saturday, creator.CreateRation() },
                { Week.Sunday, creator.CreateRation() },
            };

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