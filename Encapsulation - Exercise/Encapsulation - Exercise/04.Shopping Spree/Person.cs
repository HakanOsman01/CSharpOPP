
using Shopping_Spree;
using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
       

       
      


        public Person(string name,int money)
        {
            this.Name = name;
            this.Money = money;
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
                name=value;
            }
        }
        public int Money 
        {
            get
            {
                return money;
            }
           set
           {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessage.ExceptionMoneyMessages);
                }
                money=value;
           }
            
        }
      

        
        

    }
}
