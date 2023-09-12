
using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, int foodEaten, string livingRegion,string breed) 
            : base(name, weight, foodEaten, livingRegion)
        {
            Breed = breed;
        }
        public string Breed { get;private set; }

       
        
    }
}
