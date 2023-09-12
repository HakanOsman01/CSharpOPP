

namespace Explicit_Interfaces
{
    using Core.Interfaces;
    using Explicit_Interfaces.Core;

    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
   
}