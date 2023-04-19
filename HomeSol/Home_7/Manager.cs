using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Manager : Employee, IWorkable
    {
        public Manager(string name, params Skills[] skills) : base(name, skills)
        {
            
        }

        public string[] DoWork()
        {
            string[] result = new string[1];

            return result;
        }

        public override string ToString()
        {
            return "Manager";
        }
    }
}
