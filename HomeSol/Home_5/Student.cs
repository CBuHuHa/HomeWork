using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
        public int MathMark { get; set; }
        public int PhysicalEducationMark { get; set; }
        public int BiologyMark { get; set; }
        public int Reward { get; set; }

        public Student(int id, string name, int age, int group)
        {
            Name = name;
            Age = age;
            Group = group;
            Id = id;
            Reward = 0;
            Random random = new Random();
            MathMark = (int)random.NextInt64(1, 11);
            PhysicalEducationMark = (int)random.NextInt64(1, 11);
            BiologyMark = (int)random.NextInt64(1, 11);
        }
    }
}
