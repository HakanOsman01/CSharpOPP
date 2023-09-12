

namespace _01._Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double fuelQuantity;
        private readonly double fuelConsumption;
        private  int tankCapacity;
        public Truck(double fuelQuantity, double fuelConsumption,int capacity) 
            : base(fuelQuantity, fuelConsumption,capacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = capacity;

        }

        public override void Drive(double km)
        {
            if (this.fuelQuantity < ((fuelConsumption * km)) + (1.6 * km))
            {
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                this.fuelQuantity -= ((fuelConsumption * km)) + (1.6 * km);
                Console.WriteLine($"Truck travelled {km} km");

            }


        }

        public override void Refueled(double fuel)
        {
            if (this.fuelQuantity + fuel > tankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                this.fuelQuantity += (fuel * 0.95);
            }
            
          
        }
        public override string ToString()
        {
            return $"{typeof(Truck).Name}: {fuelQuantity:f2}";
        }
    }
}
