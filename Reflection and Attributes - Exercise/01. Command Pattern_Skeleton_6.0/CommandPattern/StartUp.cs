

namespace CommandPattern
{
    using System;
    using Core;
    using Core.Contracts;
    using Utilities;
    using CommandPattern.Utilities.Contracts;
   
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command);
            engine.Run();
        }
    }
}
