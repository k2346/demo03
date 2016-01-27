using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_7
{
    class Kukka
    {
        //properties
        public int Pituus { get; set;}
        public string Nimi { get; set; }
        public string Laji { get; set; }
        public bool Uhanalainen { get; set; }
        public string Vari { get; set; }


        //methods
        public void PrintData()
        {
            
            Console.WriteLine("Tietoja kukista: ");
            Console.WriteLine(" Nimi: {0}", Nimi);
            Console.WriteLine(" Laji: {0}", Laji);
            Console.WriteLine(" Pituus: {0}", Pituus);
            Console.WriteLine(" Varitys: {0}", Vari);
            Console.WriteLine(" Uhanalainen: {0}", Uhanalainen);
            Console.WriteLine(" ");
        }



    }
}
