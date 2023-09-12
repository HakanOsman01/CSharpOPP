
namespace _04._Border_Control
{
    using _04._Border_Control.Engine;
    using Engine.Interfaces;
    using IO;
    using IO.Interdaces;
    




    public class StartUp
    {
        static void Main(string[] args)
        {
            IPrintebale printebale = new ConsolePrint();

            IReadebly readebly = new ConsoleReader();

            IEngine engine = new EngineClass(readebly, printebale);

            engine.Run();   
        }
    }
}