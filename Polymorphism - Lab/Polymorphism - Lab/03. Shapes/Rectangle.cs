

namespace _03._Shapes
{
    public class Rectangle : Shapes
    {
        public Rectangle(double height,double widht)
        {
            this.height = height;
            this.widht = widht;
        }
        //height and width for Rectangle
        private double height;
        private double widht;
       
        public override double CalculateArea()
        {
            return height * widht;
        }

        public override double CalculatePerimeter()
        {
            return (2 * height) + (2 * widht);
        }

        public override string Draw()
        {
            return $"Drawing {typeof(Rectangle).Name}";
        }
    }
}
