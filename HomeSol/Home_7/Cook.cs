using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Cook : Employee, IWorkable
    {
        public Cook(string name, params Skills[] skills) : base(name, skills)
        {

        }

        public string[] DoWork()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Cook";
        }
    }
}
