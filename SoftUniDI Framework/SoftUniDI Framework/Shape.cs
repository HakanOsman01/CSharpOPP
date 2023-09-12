using SoftUniDI_Framework.Renderurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework
{
    internal class Shape
    {
        private IRenderer renderer;
        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
            
        }
        public void Draw()
        {
            renderer.WriteLine("Shape");
        }
    }
}
