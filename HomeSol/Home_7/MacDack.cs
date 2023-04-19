using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class MacDack
    {
        public MacDack() 
        { 

        }
        public void DoWork(params Employee[] employee)
        {
            foreach (Employee employeer in employee)
            {
                string? prof = employeer.ToString();
                Skills[] skills = employeer.Skill;

                foreach (Skills skill in skills)
                {
                    Console.WriteLine($"{prof} is {skill}");
                }
            }
        }
    }
}
