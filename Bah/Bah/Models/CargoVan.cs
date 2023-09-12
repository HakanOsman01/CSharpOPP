﻿using System;

namespace EDriveRent.Models
{
    public class CargoVan : Vehicle
    {
        private const double MaxMileageForCargoVan = 180;
        public CargoVan(string brand, string model,string licensePlateNumber) 
            : base(brand, model, MaxMileageForCargoVan, licensePlateNumber)
        {
        }
       
    }
}
