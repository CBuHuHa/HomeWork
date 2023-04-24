using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_8
{
    public class Product
    {
        public string Name { get; set; }
        public int Calories { get; set; }

        public Product(string name, int calories) 
        { 
            Name = name;
            Calories = calories;
        }

    }
}
