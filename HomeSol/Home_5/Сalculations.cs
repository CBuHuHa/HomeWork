using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Home_5
{
    public class Сalculations
    {

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
    }
}
