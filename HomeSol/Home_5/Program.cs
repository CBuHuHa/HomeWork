using Home_5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stGroup = 1;

            Student[] group1 = new Student[5];
            for (int i = 0; i <= group1.Length - 1; i++)
            {
                int num = i;
                int id = 100 + i;
                Random random = new Random();
                string[] names = { "Francis", "Caroline", "Harold", "Alise", "Emily" };
                string name = names[i];
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group1[num] = student;
                student.InfoSt();
            }

            stGroup = 2;
            Student[] group2 = new Student[5];
            for (int i = 0; i <= group2.Length - 1; i++)
            {
                int num = i;
                int id = 200 + i;
                string[] names = { "Nancy", "Vanessa", "Roger", "Dennis", "Edward" };
                Random random = new Random();
                string name = names[i];
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group2[num] = student;
                student.InfoSt();
            }

            stGroup = 3;
            Student[] group3 = new Student[5];
            for (int i = 0; i <= group3.Length - 1; i++)
            {
                int num = i;
                int id = 300 + i;
                Random random = new Random();
                string[] names = { "Jane", "Lucas", "Lily", "Martin", "Rachel" };
                string name = names[i];
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group3[num] = student;
                student.InfoSt();
            }
            Console.WriteLine("Best student in math:");
            Сalculations.BestMath(group1, group2, group3);
            Console.WriteLine("Best student in physicalEducation:");
            Сalculations.BestPhys(group1, group2, group3);
            Console.WriteLine("Best student in biology:");
            Сalculations.BestBio(group1, group2, group3);
        }
    }
}