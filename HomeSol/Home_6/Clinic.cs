using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Home_6
{
    public class Clinic
    {
        public string? Name { get; set; }


        public Clinic(string name)
        {
            Name = name;
        }

        public static void GoToDoctor(Patient patient, Doctor[] doctors)
        {
            patient.ShowInfo();
            Console.WriteLine("We refer you to the doctor");
            Console.ReadKey();
            foreach (Doctor doctor in doctors)
            {
                if ((patient.Ilness.ToLower() == "eyes") && (doctor.Specialization == Specialization.Ophthalmologist))
                {
                    Doctor.Treat(doctor, Specialization.Ophthalmologist);
                    break;
                }
                else if ((patient.Ilness.ToLower() == "teeth") && (doctor.Specialization == Specialization.Dentist))
                {
                    Doctor.Treat(doctor, Specialization.Dentist);
                    break;
                }
                else if ((doctor.Specialization == Specialization.Therapist))
                {
                    Doctor.Treat(doctor, Specialization.Therapist);
                    break;
                }
            }
        }

        public Doctor[] DoctorCreator()
        {
            Doctor livesey = new Doctor("Livesey", Specialization.Dentist);
            Doctor odin = new Doctor("Odin", Specialization.Ophthalmologist);
            Doctor house = new Doctor("House", Specialization.Therapist);

            Doctor[] doctors = new[] { livesey, odin, house };

            return doctors;
        }

        public void ShowIhfo(Clinic clinic, Doctor[] doctors)
        {
            Console.WriteLine("Welcome to the clinic \"" + clinic.Name + "\"");
            foreach (Doctor doctor in doctors)
            {
                doctor.ShowInfo();
            }
        }
    }
}
