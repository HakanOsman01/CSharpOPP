using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Shapes
{
    public class Text : Shape
    {
        public Text(Position position, string value)
            : base(position)
        {
            Value = value;
        }
        public string Value { get; set; }
        public override void Draw()
        {
            Console.SetCursorPosition(Position.Col, Position.Row);
            Console.Write(Value);
            base.Draw();
        }
    }
}
