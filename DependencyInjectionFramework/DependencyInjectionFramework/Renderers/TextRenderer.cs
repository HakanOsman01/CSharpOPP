using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFramework.Renderers
{
    public class TextRenderer : IRenderer
    {
        private string path = @"../../../output.txt";
        public void Write(string text)
        {
           using(StreamWriter sw = new StreamWriter(path))
           {
                sw.Write(text);
           }
        }

        public void WriteLine(string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(text);
            }
        }
    }
}
