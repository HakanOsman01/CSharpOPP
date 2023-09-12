﻿


namespace Food_Shortage.Models
{
    using Interfaces;
    public class Citizen : IIdentifiel
    {
        public Citizen(string name,int age,string id,string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDay= birthday;
            Food = 0;
        }
        public string Id { get; private set; }

        public string BirthDay { get;private set; }

        public int Food { get;private set; }

        public int Age { get; private set; }

        public string Name { get;private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
