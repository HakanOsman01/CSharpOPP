using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Rectangle : Shape
    {
        public Rectangle(double widht,double height)
        {
            this.Width = widht;
            this.Height = height;
        }
        public override double Area => this.Width * this.Height;

        public virtual double Width { get; set; }

        public virtual double Height { get; set; }
    }
}
