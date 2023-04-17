using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_6
{
    public class Patient : Person
    {
        private static int id = 0;
        public int Id { get; set; }
        public string Ilness { get; set; }
        
        public Patient(string name, string ilness) : base(name)
        {
            Id = id;
            Id++;
            Ilness = ilness;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} Name: {Name} Ilness: {Ilness}");
        }
    }
}