using Home_7;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MacDack macDack = new MacDack();

            Manager alex = new Manager("Alex", Skills.managing, Skills.cooking, Skills.solving);
            Cook ivan = new Cook("Ivan", Skills.cooking, Skills.cleaning);
            Cleaner john = new Cleaner("John", Skills.cleaning);

            macDack.DoWork(alex, ivan, john);

        }
    }
}