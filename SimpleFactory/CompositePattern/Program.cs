using CompositePattern.Shapes;

namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape page = new Shape(new Position(0,0));
            Shape leftAd=new Shape(new Position(0,0));

            Rectangel leftRectangel = new Rectangel(new Position(3, 10), 30, 10);
            Line leftLine = new Line(new Position(22, 5), 30);
            Text leftText = new Text(new Position(24, 5), "The Best Offer");


            leftAd.AddChield(leftRectangel);
            leftAd.AddChield(leftLine);
            leftAd.AddChield(leftText);

            leftAd.Draw();

        }
    }
}