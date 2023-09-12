


using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
   
    public class Dog : Mammal
    {
        private const double FOOD_INCREASE = 0.40;
        private double dogWeight;
        public Dog(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
            ProduceSound();
            dogWeight = weight;
        }

        private void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
      
        public override string ToString()
        {
            return $"{typeof(Dog).Name} [{Name}, {dogWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                dogWeight += FOOD_INCREASE * food.Quantity;
            }
            else if (food is Vegetable)
            {
                Console.WriteLine($"{typeof(Dog).Name} does not eat {typeof(Vegetable).Name}!");
            }
            else if (food is Fruit)
            {
                Console.WriteLine($"{typeof(Dog).Name} does not eat {typeof(Fruit).Name}!");
            }
            else
            {
                Console.WriteLine($"{typeof(Dog).Name} does not eat {typeof(Seeds).Name}!");
            }
        }
    }
}
