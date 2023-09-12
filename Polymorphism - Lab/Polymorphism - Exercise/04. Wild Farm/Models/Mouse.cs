





namespace _04._Wild_Farm.Models
{
    using Interfaces;
    public class Mouse : Mammal
    {
        private const double FOOD_INCREASE = 0.10;
        private double mouseWeight;
        private int foodEaten = 0;
        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
            mouseWeight = weight;
            ProduceSound();
        }

        private void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
       
        public override string ToString()
        {
            return $"{typeof(Mouse).Name} [{Name}, {mouseWeight}, {LivingRegion}, {foodEaten}]";
        }

       

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                mouseWeight += FOOD_INCREASE * food.Quantity;
                foodEaten += food.Quantity;
            }
            else
            {
                if(food is Meat)
                {
                    Console.WriteLine($"{typeof(Mouse).Name} does not eat {typeof(Meat).Name}!");
                }
                else if(food is Seeds)
                {
                    Console.WriteLine($"{typeof(Mouse).Name} does not eat {typeof(Seeds).Name}!");
                }
               
            }
        }
    }
}
