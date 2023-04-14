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
        public int reward = 0;

        public int Id { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age { get; set; }
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

        public Student(int id, string name, int age, int group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.id = id;
            Random random = new Random();
            mathMark = (int)random.NextInt64(1, 11);
            physicalEducationMark = (int)random.NextInt64(1, 11);
            biologyMark = (int)random.NextInt64(1, 11);
        }

        public void InfoSt()
        {
            Console.WriteLine($"Group: {group} d: {id} Name: {name} Age: {age}  mathMark: {mathMark} physicalEducationMark: {physicalEducationMark} biologyMark: {biologyMark} reward: {reward}");
        }


    }
}
