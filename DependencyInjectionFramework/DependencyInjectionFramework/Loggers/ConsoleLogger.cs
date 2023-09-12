using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFramework.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string s)
        {
            Console.WriteLine($"LOG: {s}");
        }
    }
}
