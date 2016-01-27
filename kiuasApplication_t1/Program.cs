using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiuasApplication_t1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas();
            harvia.PrintData();
            harvia.IsOn = true;
            harvia.Temperature = 945;
            harvia.Humidity = 70;

            Kiuas puukiuas = new Kiuas();
            puukiuas.IsOn = false;
            puukiuas.Temperature = 22;
            puukiuas.Humidity = 10;

            harvia.PrintData();
            puukiuas.PrintData();

            //tulostaa vaan yhden arvon

            Console.WriteLine ("Lampotila on.. " + harvia.Temperature);

            Console.WriteLine (harvia.ToString()); //käytä tätä kotitehtävässä 5. Palauttaa yhtenä rivinä arvot
            Console.ReadLine();
        }
    }
}
