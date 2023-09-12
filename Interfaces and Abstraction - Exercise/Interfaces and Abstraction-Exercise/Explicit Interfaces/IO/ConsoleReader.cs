



namespace Explicit_Interfaces.IO
{
    using Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
        
    }
}
