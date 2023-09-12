﻿using SoftUniDI_Framework.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework.Renderurs
{
    public class ConsoleRenderer : IRenderer
    {
        private ILogger logger;
        public ConsoleRenderer(ILogger logger)
        {
            Console.WriteLine("Console Render created");
            this.logger= logger;
        }
        public void Write(string text)
        {
            logger.Log("Writing!!!");
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            logger.Log("WrittingNewLine!!!");
            Console.WriteLine(text);
        }
    }
}
