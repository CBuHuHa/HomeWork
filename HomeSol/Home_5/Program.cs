using Home_5;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Student[] group1 = new Student[5]; // Generating group 1
            for (int i = 0; i <= group1.Length - 1; i++)
            {
                int stGroup = 1;
                int id = 100 + i;
                Random random = new Random();
                string[] names = { "Francis", "Caroline", "Harold", "Alise", "Emily" };
                string name = names[i];
                group1[i] = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
            }

            
            Student[] group2 = new Student[5]; //Generating group 2
            for (int i = 0; i <= group2.Length - 1; i++)
            {
                int stGroup = 2;
                int id = 200 + i;
                string[] names = { "Nancy", "Vanessa", "Roger", "Dennis", "Edward" };
                Random random = new Random();
                string name = names[i];
                group2[i] = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
            }

            Student[] group3 = new Student[5]; //Generating group 3
            for (int i = 0; i <= group3.Length - 1; i++)
            {
                int stGroup = 3;
                int id = 300 + i;
                Random random = new Random();
                string[] names = { "Jane", "Lucas", "Lily", "Martin", "Rachel" };
                string name = names[i];
                group3[i] = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);

            }

            Console.ReadKey();
            Сalculations.InfoSt(group1, group2, group3);

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
            Сalculations.InfoSt(group1, group2, group3);
        }
    }
}