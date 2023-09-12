using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Delicacies
{
    public abstract class Delicacy
    {
        private string name;
        public Delicacy(string delicacyName, double price)
        {
            this.Name = delicacyName;
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
            }
        }
        public double Price { get; private set; }
        public override string ToString()
        {
            return $"{this.Name} - {this.Price:f2} lv";
        }

    }
}
