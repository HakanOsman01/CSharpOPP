using DependencyInjectionFramework.Loggers;
using DependencyInjectionFramework.Renderers;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionFramework.DI
{
    internal class DI
    {
        public static ServiceProvider BuildServices()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<IRenderer, ConsoleRenderer>();
            services.AddSingleton<ILogger,ConsoleLogger>();
            services.AddSingleton<Engine, Engine>();
            return services.BuildServiceProvider();
        }
    }
}
