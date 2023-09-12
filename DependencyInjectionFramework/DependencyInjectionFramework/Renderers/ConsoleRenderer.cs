using DependencyInjectionFramework.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFramework.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        private ILogger logger;
        public ConsoleRenderer(ILogger logger)
        {
            this.logger = logger;
        }
        public void Write(string text)
        {
            logger.Log("Write!!!");
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            logger.Log("Writting!!!");
            Console.WriteLine(text);
        }
    }
}
