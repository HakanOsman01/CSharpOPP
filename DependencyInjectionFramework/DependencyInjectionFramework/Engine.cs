using DependencyInjectionFramework.ChessFigures;
using DependencyInjectionFramework.Contracts;
using DependencyInjectionFramework.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionFramework
{
    public class Engine
    {
        private IRenderer renderer;
        private IDrawabel[] figures;
        public Engine(IRenderer renderer)
        {
            this.renderer = renderer;
            figures = new IDrawabel[5]
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
            while(true)
            {
                Thread.Sleep(1000);
                foreach (IDrawabel figure in figures)
                {
                    figure.Draw();
                }
                renderer.WriteLine("Chess game is running!!!");
            }
        }
    }
}
