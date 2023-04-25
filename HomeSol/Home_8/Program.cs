using Home_8;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Week, List<Product>> ration = RationCreator.GetRation();

            Console.WriteLine("Initial ration:\n");
            RationCreator.VeiwRation(ration);

            Console.Write("\nEnter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the calorie limit: ");
            int limit = int.Parse(Console.ReadLine());

            Person ivan = new Person(name, limit);

            Console.WriteLine("\nAdjusting the diet...");
            ivan.CheckRation(ration);

            Console.WriteLine($"\nFinal ration for {ivan.Name}:\n");
            RationCreator.VeiwRation(ration);
        }
    }
}