using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private double maxMilegas;
        private string licensePlateNumber;
        public Vehicle(string brand, string model, 
            double maxMileage, string licensePlateNumber)
        {
            this.Brand= brand;
            this.Model= model;
            this.MaxMileage= maxMileage;
            this.LicensePlateNumber= licensePlateNumber;
            this.BatteryLevel = 100;
            this.IsDamaged=false;
            
            
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.BrandNull);
                }
                brand = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ModelNull);
                }
                model = value;
            }
        }

        public double MaxMileage
        {
            get
            {
                return maxMilegas;
            }
            private set
            {
                maxMilegas=value;
            }
        }

        public string LicensePlateNumber
        {
            get
            {
                return licensePlateNumber;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LicenceNumberRequired);
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel { get;private set; }

        public bool IsDamaged { get;private set; }

        public void ChangeStatus()
        {
            if (this.IsDamaged == false)
            {
                this.IsDamaged = true;
            }
            else
            {
                this.IsDamaged = false;
            }
        }

        public void Drive(double mileage)
        {
            int percantege = (int)Math.Round((mileage / MaxMileage)*100);
            this.BatteryLevel-=percantege;
            if(this.GetType()== typeof(CargoVan))
            {
                this.BatteryLevel-=5;
            }
           
        }

        public void Recharge()
        {
            this.BatteryLevel = 100;
        }
        public override string ToString()
        {
            string status = IsDamaged == false ? "Ok" : "damaged";
            return $"{Brand} {Model} License plate: {LicensePlateNumber}" +
                $" Battery: {BatteryLevel}% Status: {status}";
        }
    }
}
