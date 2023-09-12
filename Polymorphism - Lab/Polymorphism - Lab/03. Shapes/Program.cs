namespace _03._Shapes
{
    public class StarUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"{circle.CalculateArea():f2}");
            Console.WriteLine($"{circle.CalculatePerimeter():f2}");
            Console.WriteLine(circle.Draw());
            Rectangle rectangle = new Rectangle(7, 5);
            Console.WriteLine(rectangle.CalculateArea());
            Console.WriteLine(rectangle.CalculatePerimeter());
            Console.WriteLine(rectangle.Draw());


        }
    }
}