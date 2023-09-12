
namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const int DefaultSportCarConsumation = 10;
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            
        }
        public override double FuelConsumption 
            => DefaultSportCarConsumation;
    }
}
