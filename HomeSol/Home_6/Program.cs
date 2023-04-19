using Home_6;
using System;
using System.Text.RegularExpressions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the clinic: ");
            Clinic ibolit = new Clinic(Console.ReadLine());
            Doctor[] doctors = ibolit.DoctorCreator();
            ibolit.ShowIhfo(ibolit, doctors);
            
            Console.Write("Patient's name: ");
            string patientName = Console.ReadLine();

            Console.Write("What is your problem?: ");
            string patientIlness = Console.ReadLine();

            Patient patient = new Patient(patientName, patientIlness);

            Clinic.GoToDoctor(patient, doctors);
        }
    }
}