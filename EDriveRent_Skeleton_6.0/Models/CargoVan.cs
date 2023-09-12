﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class CargoVan : Vehicle
    {
        public CargoVan(string brand, string model, string licensePlateNumber) 
            : base(brand, model, 180, licensePlateNumber)
        {
        }
    }
}
