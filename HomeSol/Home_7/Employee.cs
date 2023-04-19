using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Employee
    {
        public string Name { get; set; }
        public Skills[] Skill { get; set; }

        public Employee(string name, params Skills[] skills)
        {
            Name = name;
            Skill = skills;
        }
    }
}
