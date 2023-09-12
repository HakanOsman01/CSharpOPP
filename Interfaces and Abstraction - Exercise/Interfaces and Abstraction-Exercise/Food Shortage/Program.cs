

namespace Food_Shortage
{
    using Core.Interfaces;
    using Food_Shortage.Core;

    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}