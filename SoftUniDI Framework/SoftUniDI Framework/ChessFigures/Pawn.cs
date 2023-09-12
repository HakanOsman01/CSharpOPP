using SoftUniDI_Framework.Contarcts;
using SoftUniDI_Framework.Renderurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework.ChessFigures
{
    public class Pawn : IDrawebel
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
