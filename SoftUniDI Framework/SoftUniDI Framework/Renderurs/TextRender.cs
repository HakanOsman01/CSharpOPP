using SoftUniDI_Framework.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework.Renderurs
{
    public class TextRender : IRenderer
    {
        private string path = "../../../output.txt";
        private ILogger logger;
        public TextRender(ILogger logger)
        {
            this.logger = logger;
        }
        public void Write(string text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(text);
        }

        public void WriteLine(string text)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(text);
        }
    }
}
