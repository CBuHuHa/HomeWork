using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_5
{
    public class Student
    {
        public int id;
        public string name;
        public int age;
        public int group;
        public int mathMark;
        public int physicalEducationMark;
        public int biologyMark;
        public int reward = 0;

        public Student(int stId, string stName, int stAge, int stGroup) 
        { 
            name = stName;
            age = stAge; 
            group = stGroup;
            id = stId;
            Random random = new Random();
            mathMark = (int)random.NextInt64(1, 10);
            physicalEducationMark = (int)random.NextInt64(1, 10);
            biologyMark = (int)random.NextInt64(1, 10);  
        }

        public void InfoSt ()
        {
            Console.WriteLine($"Group: {group} d: {id} Name: {name} Age: {age}  mathMark: {mathMark} physicalEducationMark: {physicalEducationMark} biologyMark: {biologyMark} reward: {reward}");
        }


    }
}
