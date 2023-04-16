using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class GroupGenerator
    {
        private static string[] names = new string[] { "Francis", "Caroline", "Harold", "Alise", "Emily", "Nancy", "Vanessa", "Roger", "Dennis", "Edward", "Jane", "Lucas", "Lily", "Martin", "Rachel" };
        static int ind = 0;

        public Student[] GenerateGroup(int countStudents, int groupNumber)
        {
            Random random = new Random();
            int minRandomValue = 17;
            int maxRandomValue = 30;
            int id = 100;

            Student[] group = new Student[countStudents]; // Generating group
            for (int i = 0; i <= group.Length - 1; i++)
            {
                id++;
                string name = names[ind];
                ind++;
                group[i] = new Student(id, name, random.Next(minRandomValue, maxRandomValue), groupNumber);
            }

            return group;
        }
    }
}