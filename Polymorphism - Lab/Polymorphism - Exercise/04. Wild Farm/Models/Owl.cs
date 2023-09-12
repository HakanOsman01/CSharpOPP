


using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
    
    public class Owl : Bird
    {
        private const double FOOD_INCREASE = 0.25;
        private double owlWeight;
        private int foodEaten = 0;
        public Owl(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
            ProduceSound();
            owlWeight = weight;
        }

        private void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
       
        public override string ToString()
        {
            return $"{typeof(Owl).Name} [{Name}, {WingSize}, {owlWeight}, {foodEaten}]";
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                owlWeight += FOOD_INCREASE * food.Quantity;
                foodEaten += food.Quantity;
            }
            else if (food is Vegetable)
            {
                Console.WriteLine($"{typeof(Owl).Name} does not eat {typeof(Vegetable).Name}!");
            }
            else if (food is Fruit)
            {
                Console.WriteLine($"{typeof(Owl).Name} does not eat {typeof(Fruit).Name}!");
            }
            else
            {
                Console.WriteLine($"{typeof(Owl).Name} does not eat {typeof(Seeds).Name}!");
            }
        }
    }
}
