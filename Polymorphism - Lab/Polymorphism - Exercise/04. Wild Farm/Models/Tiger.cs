



using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
   
    public class Tiger : Feline
    {
        private const double FOOD_INCREASE = 1.00;
        private double tigerWeight;
        private int foodEaten;
        public Tiger(string name, double weight, int foodEaten, string livingRegion,string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
           
            ProduceSound();
            tigerWeight = weight;
        }

        private void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                tigerWeight += FOOD_INCREASE * food.Quantity;
                foodEaten += food.Quantity;
            }
            else if(food is Vegetable)
            {
                Console.WriteLine($"{typeof(Tiger).Name} does not eat {typeof(Vegetable).Name}!");
            }
            else if(food is Fruit)
            {
                Console.WriteLine($"{typeof(Tiger).Name} does not eat {typeof(Fruit).Name}!");
            }
            else
            {
                Console.WriteLine($"{typeof(Tiger).Name} does not eat {typeof(Seeds).Name}!");
            }



        }
        public override string ToString()
        {
            return $"{typeof(Tiger).Name} [{Name}, {Breed}, {tigerWeight}, " +
                $"{LivingRegion}, {foodEaten}]";
        }
    }
}
