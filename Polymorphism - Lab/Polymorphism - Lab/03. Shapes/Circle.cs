﻿

namespace _03._Shapes
{
    public class Circle : Shapes
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI*Math.Pow(radius, 2);

        }

        public override double CalculatePerimeter()
        {
            return 2*Math.PI*radius;
        }

        public override string Draw()
        {
            return $"Drawing {typeof(Circle).Name}";
        }
    }
}
