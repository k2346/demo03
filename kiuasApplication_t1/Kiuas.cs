using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiuasApplication_t1
{
    class Kiuas //properties
    {
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public void PrintData() //tulostaa konsolille metodi
        {
            Console.WriteLine("Kiukaan ominaisuudet:");
            Console.WriteLine("- Onko se paalla : {0}", IsOn);
            Console.WriteLine("- Lampotila : {0}", Temperature);
            Console.WriteLine("- Kosteus : {0}", Humidity);
        }


        //methods returns object properties in one string, palauttaa ominaisuudet yhtenä merkkijonona
        public override string ToString()
        {
            return "Lampotila =" + Temperature + "Kosteus = " + Humidity + "Onko se paalla? " + IsOn;

        }
    }
}
