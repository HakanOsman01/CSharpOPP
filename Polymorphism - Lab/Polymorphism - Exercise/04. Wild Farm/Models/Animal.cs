
namespace _04._Wild_Farm.Models
{
    public abstract class Animal
    {
        protected Animal(string name,double weight,int foodEaten) 
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;  
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; private set; }

    }
}
