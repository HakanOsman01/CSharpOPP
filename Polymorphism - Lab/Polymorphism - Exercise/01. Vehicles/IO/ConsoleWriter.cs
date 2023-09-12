

using _01._Vehicles.IO.Interfaces;

namespace _01._Vehicles.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteLine()
        {
            throw new NotImplementedException();
        }
    }
}
