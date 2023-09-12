

namespace _04._Wild_Farm.Models
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; private set; }
    }
}
