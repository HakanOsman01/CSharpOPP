using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Cocktails
{
    public abstract class Cocktail
    {
        private string name;
        private double price;
        private string size;
        public Cocktail(string cocktailName, string size, double price)
        {
            this.Name = cocktailName;
            this.Size= size;
            this.Price = price;
        }
        public string Name 
        {
            get
            {
                return name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.NameNullOrWhitespace);
                }
                name = value;
            }
        }
        public string Size
        {
            get
            {
                return size;

            }
            private set
            {
                size=value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            private set
            {
                if(this.Size== "Middle")
                {
                    price = value * (2 / 3.00);
                }
                else if(this.Size== "Small")
                {
                    price = value * (1 / 3.00);
                }
                else
                {
                    price = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{this.Name} ({this.Size}) - {this.Price:f2} lv";
        }

    }
}
