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

        public static void GoToDoctor(Patient patient, Doctor[] doctors)
        {
            for (int i = 0; i < doctors.Length; i++)
            {
                switch(patient.Ilness == "Eyes " && doctors[i].Specialization == Specialization.Ophthalmologist)
                {

                }
            }
         
        }
    }
}
