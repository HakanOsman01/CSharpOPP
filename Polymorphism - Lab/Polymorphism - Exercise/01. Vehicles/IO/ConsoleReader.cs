

namespace _01._Vehicles.IO
{
    using Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();
       
    }
}
