
namespace _01._Vehicles.Models
{
    using Interfaces;
    public abstract class Vehicle : IDrivable
    {
        private int tankCapacity;
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption,int tankCapacity ) 
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            private set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption { get; }

        public int TankCapacity 
        {
            get
            {
                return this.tankCapacity;

            } 
            private set
            {
                if(value>fuelQuantity)
                {
                    this.tankCapacity=0;
                }
                else
                {
                    this.tankCapacity=value;
                }
            } 
        }

        public abstract void Drive(double km);


        public abstract void Refueled(double fuel);
      

    }
}
