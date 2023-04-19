using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class Cleaner : Employee, IWorkable
    {
        public Cleaner(string name, params Skills[] skills) : base(name, skills)
        {
            
        }

        public string[] DoWork()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Cleaner";
        }
    }
}
