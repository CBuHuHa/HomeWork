using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name) { }

        public override string ToString()
        {
            return "Manager";
        }

        public override void Working(params ISkillable[] skill)
        {
            foreach (ISkillable skillItem in skill)
            {
                string sk = skillItem.GetSkill();
                string man = ToString();
                Console.WriteLine($"{man} is {sk}");
            }
        }
    }
}
