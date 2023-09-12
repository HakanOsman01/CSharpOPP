using SoftUniDI_Framework.ChessFigures;
using SoftUniDI_Framework.Contarcts;
using SoftUniDI_Framework.Renderurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI_Framework
{
    public class Engine
    {
        private IRenderer renderer;
        private IDrawebel[] figures;
        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            this.figures = new IDrawebel[5]
            {
                  new Pawn(renderer),
                  new Pawn(renderer),
                  new Pawn(renderer),
                  new Pawn(renderer),
                  new Pawn(renderer),

            };
        }
        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                foreach (var item in figures)
                {
                    item.Draw();
                }
                renderer.WriteLine("Chess game runnig");
            }

        }
    }
}
