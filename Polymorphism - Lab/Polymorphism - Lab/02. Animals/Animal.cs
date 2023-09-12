

namespace _02._Animals
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;
        protected Animal(string name,string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }
        
        public abstract string ExplainSelf();
        public override string ToString()
        {
            return $"I am {name} and my fovourite food is {favouriteFood} ";
        }
     

    }
}
