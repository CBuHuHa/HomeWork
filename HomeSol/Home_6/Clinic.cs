using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Home_6
{
    public class Clinic
    {
        public string? Name { get; set; }


        public Clinic(string name)
        {
            Name = name;
            Console.WriteLine("Welcome to the clinic \"" + name + "\"");
        }

        public static void GoToDoctor(IlnessType ilnessType)
        {
            switch (ilnessType)
            {
                case IlnessType.Eyes:
                    Doctor.Treat(Specialization.Ophthalmologist);
                    break;
                case IlnessType.Teeth:
                    Doctor.Treat(Specialization.Ophthalmologist);
                    break;
                case IlnessType.Other:
                    Doctor.Treat(Specialization.Ophthalmologist);
                    break;
            }
        }
    }
}
