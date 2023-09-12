

namespace Food_Shortage.Models
{
    using Interfaces;
    public class Rebel : IGroupebale
    {
        public Rebel(string name,int age,string group)
        {
            Name = name;
            Age = age;
            Group = group;
            this.Food = 0;
        }
        public string Group { get;private set; }

        public int Food { get; private set; }

        public int Age { get;private set; }

        public string Name { get;private set; } 

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
