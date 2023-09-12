

using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
    public abstract class Bird : Animal,IEatable
    {
        protected Bird(string name, double weight, int foodEaten,double wingSize) 
            : base(name, weight, foodEaten)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; private set; }

        public abstract void Eat(Food food);
      
    }
}
