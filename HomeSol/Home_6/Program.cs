using Home_6;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic ibolit = new Clinic("ibolit");
            
            Doctor livesey = new Doctor("Livesey", Specialization.Dentist);
            Doctor odin = new Doctor("Odin", Specialization.Ophthalmologist);
            Doctor house = new Doctor("House", Specialization.Therapist);

            Doctor[] doctors = new[] { livesey, odin, house };

            livesey.ShowInfo();
            odin.ShowInfo();
            house.ShowInfo();

            Console.Write("Patient's name: ");
            string patientName = Console.ReadLine();

            Console.Write("What is your problem?: ");
            string patientIlness = Console.ReadLine();

            Patient alex = new Patient(patientName, patientIlness);

            alex.ShowInfo();


            //Clinic.GoToDoctor(patientIlness);


            //Console.WriteLine("Hello, " + patientName + ", we refer you to the doctor House m.d.");
        }
    }
}