

namespace _01._Vehicles.Models
{
    public class Car : Vehicle
    {
        private double fuelQuantity;
        private readonly double fuelConsumption;
        private readonly int tankCapacity;
        public Car(double fuelQuantity, double fuelConsumption,int capacity) 
            : base(fuelQuantity, fuelConsumption, capacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = capacity;
        }

        public override void Drive(double km)
        {
            if (this.fuelQuantity < ((fuelConsumption * km)) + (0.9 * km))
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                this.fuelQuantity -= ((fuelConsumption * km)) + (0.9 * km);
                Console.WriteLine($"Car travelled {km} km");

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
                this.fuelQuantity += fuel;
            }
            
        }
        public override string ToString()
        {
            return $"{typeof(Car).Name}: {fuelQuantity:f2}";
        }
    }
}
