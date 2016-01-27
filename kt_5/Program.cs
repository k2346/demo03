using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija[] opiskelijat = new Opiskelija[5];
            opiskelijat[0] = new Opiskelija();
            opiskelijat[0].Name = "Maija";
            opiskelijat[0].Age = 17;
            opiskelijat[0].Class = "KA08Y";
            opiskelijat[0].Stupid = true;

            opiskelijat[1] = new Opiskelija();
            opiskelijat[1].Name = "Kaapo";
            opiskelijat[1].Age = 22;
            opiskelijat[1].Class = "TTV15S2";
            opiskelijat[1].Stupid = true;

            opiskelijat[2] = new Opiskelija();
            opiskelijat[2].Name = "Irma";
            opiskelijat[2].Age = 89;
            opiskelijat[2].Class = "ei luokkaa";
            opiskelijat[2].Stupid = false;

            opiskelijat[3] = new Opiskelija();
            opiskelijat[3].Name = "Jorma";
            opiskelijat[3].Age = 4;
            opiskelijat[3].Class = "1";
            opiskelijat[3].Stupid = false;

            opiskelijat[4] = new Opiskelija();
            opiskelijat[4].Name = "Terhi";
            opiskelijat[4].Age = 12;
            opiskelijat[4].Class = "7";
            opiskelijat[4].Stupid = true;

            foreach (Opiskelija opiskelija in opiskelijat) {
                opiskelija.PrintData();
            }
            Console.ReadLine();
        }
    }
}
