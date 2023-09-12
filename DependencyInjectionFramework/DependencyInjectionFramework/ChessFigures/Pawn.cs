using DependencyInjectionFramework.Contracts;
using DependencyInjectionFramework.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFramework.ChessFigures
{
    public class Pawn : IDrawabel
    {
        private IRenderer renderer;
        public Pawn(IRenderer renderer)
        {
            this.renderer = renderer;
            
        }
        public void Draw()
        {
            renderer.Write("P");
        }
    }
}
