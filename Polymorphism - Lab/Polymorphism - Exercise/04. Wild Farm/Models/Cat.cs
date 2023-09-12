

using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
   

    public class Cat : Feline
    {
        private const double FOOD_INCREASE = 0.30;
        private double catWeight;
        private int foodEaten = 0;
        public Cat(string name, double weight, int foodEaten, string livingRegion,string breed) 
            : base(name, weight, foodEaten, livingRegion,breed)
        {

            ProduceSound();
            catWeight = weight;
        }

        private void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
     
        public override string ToString()
        {
            return $"{typeof(Cat).Name} [{Name}, {this.Breed}, {catWeight}, " +
                 $"{LivingRegion}, {foodEaten}]";
        }

        public override void Eat(Food food)
        {
            if (food is Meat || food is Vegetable)
            {
                catWeight += FOOD_INCREASE * food.Quantity;
                foodEaten += food.Quantity;
            }
            else
            {
                //Type type = this.GetType().UnderlyingSystemType;
                if(food is Fruit)
                {
                    Console.WriteLine($"{typeof(Cat).Name} does not eat {typeof(Fruit).Name}!");
                }
                else
                {
                    Console.WriteLine($"{typeof(Cat).Name} does not eat {typeof(Seeds).Name}!");
                }
               
            }
        }

       
    }
}
