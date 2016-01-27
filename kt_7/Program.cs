using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Kukka[] kukkia = new Kukka[6];

            kukkia[0] = new Kukka();
            kukkia[0].Nimi = "Kiinanruusu";
            kukkia[0].Laji = "rosa-sinensis";
            kukkia[0].Pituus = 35;
            kukkia[0].Uhanalainen = false;
            kukkia[0].Vari = "Punainen";

            kukkia[1] = new Kukka();
            kukkia[1].Nimi = "Isoauringonkukka";
            kukkia[1].Laji = "annuus";
            kukkia[1].Pituus = 200;
            kukkia[1].Uhanalainen = false;
            kukkia[1].Vari = "Keltainen";

            kukkia[2] = new Kukka();
            kukkia[2].Nimi = "Keto-orvokki";
            kukkia[2].Laji = "tricolor";
            kukkia[2].Pituus = 15;
            kukkia[2].Uhanalainen = false;
            kukkia[2].Vari = "Sini-keltainen";

            kukkia[3] = new Kukka();
            kukkia[3].Nimi = "Hämeenkylmänkukka";
            kukkia[3].Laji = "patens";
            kukkia[3].Pituus = 30;
            kukkia[3].Uhanalainen = true;
            kukkia[3].Vari = "Violetinsininen";

            kukkia[4] = new Kukka();
            kukkia[4].Nimi = "Punavalkku";
            kukkia[4].Laji = "rubra";
            kukkia[4].Pituus = 50;
            kukkia[4].Uhanalainen = true;
            kukkia[4].Vari = "Vaaleanpunainen";

            kukkia[5] = new Kukka();
            kukkia[5].Nimi = "Metsätähti";
            kukkia[5].Laji = "europaea";
            kukkia[5].Pituus = 6;
            kukkia[5].Uhanalainen = false;
            kukkia[5].Vari = "Valkoinen";

          

            foreach (Kukka kukka in kukkia)
            {
                kukka.PrintData();
            }
            Console.ReadLine();
        }
        }
    }

