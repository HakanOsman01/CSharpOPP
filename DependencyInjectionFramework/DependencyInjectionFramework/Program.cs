using DependencyInjectionFramework.Loggers;
using DependencyInjectionFramework.Renderers;
using Microsoft.Extensions.DependencyInjection;
using DependencyInjectionFramework.DI;

namespace DependencyInjectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ILogger logger=new ConsoleLogger();
            //IRenderer renderer = new ConsoleRenderer(logger);
            //Engine engine = new Engine(renderer);
            //engine.Run();
            ServiceProvider serviceProvider = DI.DI.BuildServices();
            Engine engine = serviceProvider.GetService<Engine>();
            engine.Run();
        }
    }
}