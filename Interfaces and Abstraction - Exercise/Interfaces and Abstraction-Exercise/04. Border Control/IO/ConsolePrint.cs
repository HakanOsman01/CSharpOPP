

namespace _04._Border_Control.IO
{
    using Interdaces;
    public class ConsolePrint : IPrintebale
    {
        public void PrintId(string id)
        {
            Console.WriteLine(id);
        }
    }
}
