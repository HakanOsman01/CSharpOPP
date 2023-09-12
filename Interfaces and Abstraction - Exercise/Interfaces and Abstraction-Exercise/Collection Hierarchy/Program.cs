using Collection_Hierarchy.Core;
using Collection_Hierarchy.Core.Interfaces;

namespace Collection_Hierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();   
        }
    }
}