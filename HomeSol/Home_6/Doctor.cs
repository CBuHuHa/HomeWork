using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_6
{
    public class Doctor : Person
    {
        public Specialization Specialization { get; set; }

        public Doctor(string name, Specialization specialization) : base(name)
        {
            Specialization = specialization;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Specialization}: dr. {Name}");
        }

        public static void Treat(Specialization specialization)
        {
            switch (specialization)
            {
                case Specialization.Ophthalmologist:
                    Console.WriteLine("Fixed your eyes");
                    break;
                case Specialization.Dentist:
                    Console.WriteLine("Fixed your teeth");
                    break;
                case Specialization.Therapist:
                    Console.WriteLine("Fixed you");
                    break;
            }
        }
    }
}
