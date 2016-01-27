﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_4_vehicle
{
    class Vehicle
        //properties
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //methods
        public void PrintData()
        {
            Console.WriteLine("Vehicle properties: ");
            Console.WriteLine("- Name: {0}", Name);
            Console.WriteLine("- Speed: {0}", Speed);
            Console.WriteLine("- Tyres: {0}", Tyres);
        }

        public override string ToString()
        {
            return "Name = " + Name + " Speed = " + Speed + " Tyres =  " + Tyres;
        }
    }
}
