using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Cake : Dessert
    {
        //•	Grams = 250
        //•	Calories = 1000
        //•	CakePrice = 5
        private const double DefaultGramsOfCake = 250;
        private const double DefaultCaloriesOfCake = 1000;
        private const decimal DefaultCakePrice = 5m;

        public Cake(string name) 
            : base(name, DefaultCakePrice, DefaultGramsOfCake ,DefaultCaloriesOfCake)
        {
            
        }
    }
}
