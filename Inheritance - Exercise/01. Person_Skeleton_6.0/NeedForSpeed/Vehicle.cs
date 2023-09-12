
namespace NeedForSpeed
{
    public class Vehicle
    {
        //•	FuelConsumption
        //DefaultFuelConsumption – double
        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        public int HorsePower { get; set; }

        public double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption
        {
            get
            {
                return DefaultFuelConsumption;
            }
            
            
        }
        public double Fuel { get; set; }

       

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * FuelConsumption;

            
        }
    }
}
