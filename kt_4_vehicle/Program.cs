using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_4_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle mopo = new Vehicle();

            mopo.PrintData(); //tulostaa olion oletusarvot
            mopo.Name = "Yamaha"; //muutetaan arvoja
            mopo.Speed = 270;
            mopo.Tyres = 2;

            mopo.PrintData(); //tulostetaan muutetut arvot

            Console.WriteLine(mopo.ToString()); //palauttaa arvot yhtenä rivinä.
            Console.ReadLine();
        }

    }
}
