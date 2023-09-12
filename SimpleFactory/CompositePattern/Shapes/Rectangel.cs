using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Shapes
{
    public class Rectangel : Shape
    {
        public Rectangel(Position position,int widht,int height) 
            : base(position)
        {
            this.Widht=widht;
            this.Height=height;
        }
        public int Widht { get; set; }
        public int Height { get; set; }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Widht; j++)
                {
                    Console.SetCursorPosition(Position.Col+j,Position.Row+i);   

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            base.Draw();
        }
    }
}
