using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_7
{
    public class MacDack
    {
        public string Title { get; set; }
        public MacDack(string title)
        {
            Title = title;
            Console.WriteLine(title);
        }
    }
}
