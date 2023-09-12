
namespace Military_Elite
{
    using System;
    using IO;
    using Military_Elite.Core;
    using Military_Elite.Core.Interfaces;
    using Military_Elite.IO.Interfaces;
    
    public class StartUp
    {
        

        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();

            IWriter writer = new ConsoleWriter();

            IEngine engine=new Engine(reader,writer);

            engine.Run();

        }
    }
}