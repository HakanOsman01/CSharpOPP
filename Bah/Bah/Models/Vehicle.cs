using System;
using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private string licensePlateNumber;
        private int batteryLevel;
        protected Vehicle(string brand, string model, 
            double maxMileage, string licensePlateNumber)
        {
            this.Brand=brand;
            this.Model=model;
            this.MaxMileage=maxMileage;
            this.LicensePlateNumber=licensePlateNumber;
            batteryLevel = 100;
            IsDamaged = false;

        }
        public string Brand
        {
            get => brand;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);

                }
                brand = value;
            }
        }

        public string Model
        {
            get=> model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }

        public double MaxMileage { get;private set; }

        public string LicensePlateNumber
        {
            get => licensePlateNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel
        {
            get
            {
                return batteryLevel;
            }
        }

        public bool IsDamaged { get;private set; }

        public void ChangeStatus()=>this.IsDamaged=!this.IsDamaged;
        public void Drive(double mileage)
        {

            double percentage = Math.Round((mileage / this.MaxMileage) * 100);
            this.batteryLevel -= (int)percentage;

            if (this.GetType().Name == nameof(CargoVan))
            {
                this.batteryLevel -= 5;
            }

        }
        public void Recharge() => batteryLevel = 100;
        public override string ToString()
        {
            string status = this.IsDamaged ? "Ok" : "damaged";
            return $"{Brand} {Model} License plate: " +
                $"{LicensePlateNumber} Battery: " +
                $"{BatteryLevel}% Status: {status}";

        }


    }
}
