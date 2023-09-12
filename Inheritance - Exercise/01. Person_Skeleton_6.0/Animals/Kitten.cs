﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        private const string DefaultGenderFemale = "Female";
        public Kitten(string name, int age) 
         : base(name, age, DefaultGenderFemale)
        {

        }
        public override string ProduceSound()
        {
            return $"Meow";
        }
    }
}
