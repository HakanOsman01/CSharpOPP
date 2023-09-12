

namespace _03._Raiding
{
    using Core;
    using _03._Raiding.Core.Interfaces;
    using Enums;
    using Models;
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}