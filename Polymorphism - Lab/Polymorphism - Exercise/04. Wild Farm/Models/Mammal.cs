
using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
    public abstract class Mammal : Animal,IEatable
    {
        protected Mammal(string name, double weight, int foodEaten,string livingRegion) 
            : base(name, weight, foodEaten)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; set; }

        public abstract void Eat(Food food);
       
    }
}
