

namespace _01._Vehicles.Models
{
    public class Bus : Vehicle
    {
        private int tankCapacity;
        private double fuelQuantity;
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            this.fuelQuantity = fuelQuantity;
        }

        public void Drive(double km,bool isBusEmpty)
        {
            if (isBusEmpty)
            {
                if (this.fuelQuantity < (FuelConsumption * km))
                {
                    Console.WriteLine("Bus needs refueling");
                }
                else
                {
                    this.fuelQuantity -= (FuelConsumption * km);
                    Console.WriteLine($"Bus travelled {km} km");

                }
            }
            else
            {
                if (this.fuelQuantity < ((FuelConsumption * km)) + (1.4 * km))
                {
                    Console.WriteLine("Bus needs refueling");
                }
                else
                {
                    this.fuelQuantity -= ((FuelConsumption * km)) + (1.4 * km);
                    Console.WriteLine($"Bus travelled {km} km");

                }
            }
        }

        public override void Drive(double km)
        {
            throw new NotImplementedException();
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
            return $"{typeof(Bus).Name}: {fuelQuantity:f2}";
        }
    }
}
