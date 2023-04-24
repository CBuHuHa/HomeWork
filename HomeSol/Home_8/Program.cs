using Home_8;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", 3000);

            Dictionary<Week, List<Product>> ration = RationCreator.GetRation();

            RationCreator.VeiwRation(ration);


        } 
    }
}