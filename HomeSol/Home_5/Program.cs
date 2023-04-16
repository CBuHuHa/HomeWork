using Home_5;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroupGenerator generator = new GroupGenerator();

            Student[] group1 = generator.GenerateGroup(5, 1);
            Student[] group2 = generator.GenerateGroup(5, 2);
            Student[] group3 = generator.GenerateGroup(5, 3);

            Console.ReadKey();
            Сalculations.ShowStudentsInfo(group1, group2, group3);

            Console.ReadKey();
            Console.WriteLine("Best student in math:");
            Сalculations.BestMath(group1, group2, group3);

            Console.ReadKey();
            Console.WriteLine("Best student in physicalEducation:");
            Сalculations.BestPhys(group1, group2, group3);

            Console.ReadKey();
            Console.WriteLine("Best student in biology:");
            Сalculations.BestBio(group1, group2, group3);

            Console.ReadKey();
            Сalculations.RewMath(group1, group2, group3);

            Console.ReadKey();
            Сalculations.ShowStudentsInfo(group1, group2, group3);
        }
    }
}