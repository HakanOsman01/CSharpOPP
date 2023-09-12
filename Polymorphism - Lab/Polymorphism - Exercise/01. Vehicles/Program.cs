using _01._Vehicles.Core;
using _01._Vehicles.Core.Interfaces;

namespace _01._Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}