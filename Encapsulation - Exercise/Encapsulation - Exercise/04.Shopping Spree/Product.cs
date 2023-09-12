

using ShoppingSpree;
using System;

namespace Shopping_Spree
{
   public class Product
   {
        private string name;
        private int cost;
        public Product(string name,int cost)
        {
            this.Name=name;
            this.Cost = cost;
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessage.ExceptionNameMessages);
                }
                name = value;
            }
        }
        public int Cost 
        {
            get 
            {
                return cost; 
            } 
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage.ExceptionMoneyMessages);
                }
                cost = value;
            }
        }

    }
}
