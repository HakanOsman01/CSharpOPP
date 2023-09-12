using Microsoft.Extensions.DependencyInjection;
using SoftUniDI_Framework.Loggers;
using SoftUniDI_Framework.Renderurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework.DI
{
    public class DI
    {
        public static ServiceProvider BuildServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IRenderer, ConsoleRenderer>();
            serviceCollection.AddSingleton<ILogger, ConsoleLogger>();
            serviceCollection.AddSingleton<Engine, Engine>();
            serviceCollection.AddSingleton<Shape, Shape>();
            return serviceCollection.BuildServiceProvider();

        }
    }
}
