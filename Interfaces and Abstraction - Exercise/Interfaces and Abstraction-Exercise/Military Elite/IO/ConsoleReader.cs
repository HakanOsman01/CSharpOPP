

namespace Military_Elite.IO
{

    using Interfaces;
    public class ConsoleReader : IReader
    {
        public string ReadlLine() => Console.ReadLine();
      
    }
}
