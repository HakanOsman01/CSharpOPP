using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Shapes
{
    public class Line : Shape
    {
        public Line(Position position,int lenght) 
            : base(position)
        {
            this.Lenght= lenght;

        }
        public int Lenght { get; set; }
        public override void Draw()
        {
            Console.SetCursorPosition(Position.Col, Position.Row);
            for (int i = 0; i < Lenght; i++)
            {
                Console.Write("-");
            }
            base.Draw();
        }
    }
}
