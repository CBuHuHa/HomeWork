using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private int group;
        private int mathMark;
        private int physicalEducationMark;
        private int biologyMark;
        private int reward;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int MathMark
        {
            get { return mathMark; }
            set { mathMark = value; }
        }
        public int PhysicalEducationMark
        {
            get { return physicalEducationMark; }
            set { physicalEducationMark = value; }
        }
        public int BiologyMark
        {
            get { return biologyMark; }
            set { biologyMark = value; }
        }

        public int Reward
        {
            get { return reward; }
            set
            {
               reward = value;
            }
        }

        public Student(int id, string name, int age, int group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.id = id;
            reward = 0;
            Random random = new Random();
            mathMark = (int)random.NextInt64(1, 11);
            physicalEducationMark = (int)random.NextInt64(1, 11);
            biologyMark = (int)random.NextInt64(1, 11);
        }
    }
}
