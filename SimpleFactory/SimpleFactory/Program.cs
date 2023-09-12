using SimpleFactory.Models.Contracts;
using System;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            while(true)
            {
                Console.WriteLine("What to crate?");
                string typeCar = Console.ReadLine();
                int horsePower=int.Parse(Console.ReadLine());
                ICar car = carFactory.CreateCar(typeCar, horsePower);
                if (car == null)
                {
                    break;
                }
                car.Accselarate(100);
                Console.WriteLine(car.HorsePower);
                Console.WriteLine($"{car.GetType().Name}-{car.HorsePower}");
                
            }
           

        }
    }
}