using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_5
{
    public class Сalculations
    {
        /// <summary>
        /// Output of all information about students
        /// </summary>
        /// <param name="groups"></param>
        public static void ShowStudentsInfo(params Student[][] groups)
        {
            foreach (Student[] n in groups)
            {
                foreach (Student s in n)
                {
                    Console.WriteLine($"Group: {s.Group} d: {s.Id} Name: {s.Name} Age: {s.Age}  mathMark: {s.MathMark} physicalEducationMark: {s.PhysicalEducationMark} biologyMark: {s.BiologyMark} reward: {s.Reward}р.");
                }
            }

        }
        /// <summary>
        /// Returns the index of the student with the best biology score in the group (array)
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static Student MaxBio(Student[] group)
        {
            int max = 0;
            int index = 0;

            for (int i = 0; i < group.Length - 1; i++)
            {
                if (group[i].BiologyMark > max)
                {
                    index = i;
                    max = group[i].BiologyMark;
                }
            }

            return group[index];
        }

        /// <summary>
        /// Returns the index of the student with the best physical education score in the group (array)
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static Student MaxPhys(Student[] group)
        {
            int max = 0;
            int index = 0;

            for (int i = 0; i < group.Length - 1; i++)
            {
                if (group[i].PhysicalEducationMark > max)
                {
                    index = i;
                    max = group[i].PhysicalEducationMark;
                }
            }

            return group[index];
        }

        /// <summary>
        /// Returns the index of the student with the best math score in the group(array)
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public static Student MaxMath(Student[] group)
        {
            int max = 0;
            int index = 0;

            for (int i = 0; i < group.Length - 1; i++)
            {
                if (group[i].MathMark > max)
                {
                    index = i;
                    max = group[i].MathMark;
                }
            }

            return group[index];
        }

        /// <summary>
        /// Create a method to output to the console the student from each group with the best Math score. If there are students with the same best grades, output any of them. (ex: Anton, Math mark: 10)
        /// </summary>
        /// <param name="groups"></param>
        public static void BestMath(params Student[][] groups)
        {
            foreach (Student[] n in groups)
            {
                Student bestStudent = Сalculations.MaxMath(n);
                int mark = bestStudent.MathMark;
                string name = bestStudent.Name;
                int numGroup = bestStudent.Group;

                Console.Write("Group" + numGroup + " ");
                Console.WriteLine(name + " Math mark: " + mark);
            }
        }

        /// <summary>
        /// Create a method to output to the console the student from each group with the best grade in Physical Education. If there are students with the same best grades, output any of them.
        /// </summary>
        /// <param name="groups"></param>
        public static void BestPhys(params Student[][] groups)
        {
            foreach (Student[] n in groups)
            {
                Student bestStudent = Сalculations.MaxPhys(n);
                int mark = bestStudent.PhysicalEducationMark;
                string name = bestStudent.Name;
                int numGroup = bestStudent.Group;

                Console.Write("Group" + numGroup + " ");
                Console.WriteLine(name + " Phys mark: " + mark);
            }
        }

        /// <summary>
        /// Create a method to output to the console the student from each group with the best grade in Biology. If there are students with the same best grades, output any of them.
        /// </summary>
        /// <param name="groups"></param>
        public static void BestBio(params Student[][] groups)
        {
            foreach (Student[] n in groups)
            {
                Student bestStudent = Сalculations.MaxBio(n);
                int mark = bestStudent.BiologyMark;
                string name = bestStudent.Name;
                int numGroup = bestStudent.Group;

                Console.Write("Group" + numGroup + " ");
                Console.WriteLine(name + " Bio mark: " + mark);
            }
        }

        public static void RewMath(params Student[][] groups)
        {
            Random random = new Random();
            int rew = (int)random.NextInt64(1, 100);
            foreach (Student[] n in groups)
            {
                Student bestStudentM = Сalculations.MaxMath(n);
                bestStudentM.Reward = bestStudentM.Reward + rew;
            }
            foreach (Student[] n in groups)
            {
                Student bestStudentP = Сalculations.MaxPhys(n);
                bestStudentP.Reward = bestStudentP.Reward+ rew;
            }
            foreach (Student[] n in groups)
            {
                Student bestStudentB = Сalculations.MaxBio(n);
                bestStudentB.Reward = bestStudentB.Reward + rew;
            }
            Console.WriteLine("Rewards OK");
        }
    }
}
