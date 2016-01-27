using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new car object
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Red";
            car.Engine = 2.0;
            car.DoorCount = 1;
            car.Accelerate();
            car.PrintData();

            //create another car object
            string model = "Batmobil";
            Car car2 = new Car(model);
            car2.PrintData();
            car2.Color = "Black";
            car2.Engine = 6.2;
            car2.DoorCount = 10;
            car2.Brake();
            car2.PrintData();

            Console.ReadLine();
         
        }
    }
}
