



using _04._Wild_Farm.Models.Interfaces;

namespace _04._Wild_Farm.Models
{
    
    public class Hen : Bird
    {
        private const double FOOD_INCREASE= 0.35;
        private double henWeight;
        private int foodEaten=0;
        public Hen(string name, double weight, int foodEaten, double wingSize) : base(name, weight, foodEaten, wingSize)
        {
            ProduceSound();
            henWeight = weight;
            
        }

        private void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
       
        public override string ToString()
        {
            return $"{typeof(Hen).Name} [{Name}, {WingSize}, {henWeight}, {foodEaten}]";
        }

        public override void Eat(Food food)
        {
            henWeight += FOOD_INCREASE * food.Quantity;
            foodEaten += food.Quantity;
        }
    }
}
