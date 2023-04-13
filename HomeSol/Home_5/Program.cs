using Home_5;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stGroup = 1;

            Student[] group = new Student[5];
            for (int i = 0; i <= 4; i++)
            {
                int num = i;
                int id = 100 + i;
                Random random = new Random();
                string name = Convert.ToString(random.NextInt64(100, 200));
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group[num] = student;
                student.InfoSt();
            }

            stGroup++;
            Student[] group2 = new Student[5];
            for (int i = 0; i <= 4; i++)
            {
                int num = i;
                int id = 200 + i;
                Random random = new Random();
                string name = Convert.ToString(random.NextInt64(100, 200));
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group2[num] = student;
                student.InfoSt();
            }

            stGroup++;
            Student[] group3 = new Student[5];
            for (int i = 0; i <= 4; i++)
            {
                int num = i;
                int id = 300 + i;
                Random random = new Random();
                string name = Convert.ToString(random.NextInt64(100, 200));
                Student student = new Student(id, name, (int)random.NextInt64(17, 25), stGroup);
                group3[num] = student;
                student.InfoSt();
            }
        }
    }
}