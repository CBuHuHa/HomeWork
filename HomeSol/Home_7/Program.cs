using Home_7;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MacDack macDack = new MacDack("McDonald’s");

            Manager manager = new Manager("Ivan");
            Cook cook = new Cook("Jamie");
            Cleaner cleaner = new Cleaner("Vasya");
            Console.WriteLine($"Manager: {manager.Name}, cook: {cook.Name}, cleaner: {cleaner.Name}");

            Managing managing = new Managing();
            Cooking cooking = new Cooking();
            Cleaning cleaning = new Cleaning();
            Solving solving = new Solving();

            Console.ReadKey();

            manager.Working(managing, solving, cooking);
            cook.Working(cooking, cleaning);
            cleaner.Working(cleaning);
        }
    }
}