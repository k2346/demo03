using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_5
{
    class Opiskelija
    {   //properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public bool Stupid { get; set; }

        //methods
        public void PrintData()
        {
            Console.WriteLine("Student properties: ");
            Console.WriteLine("- Name: {0}", Name);
            Console.WriteLine("- Age: {0}", Age);
            Console.WriteLine("- Class: {0}", Class);
            Console.WriteLine("- Stupid: {0}", Stupid);
        }
    }
}
