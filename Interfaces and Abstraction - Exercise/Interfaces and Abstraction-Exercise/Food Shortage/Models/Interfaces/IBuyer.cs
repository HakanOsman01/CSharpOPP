

namespace Food_Shortage.Models.Interfaces
{
    public interface IBuyer
    {
        int Food { get;}
        void BuyFood();
        int Age { get; }
        string Name { get; }

    }
}
