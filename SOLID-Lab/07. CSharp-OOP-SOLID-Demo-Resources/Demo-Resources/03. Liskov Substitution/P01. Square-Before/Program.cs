using System;

namespace P01._Square_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape regtangle = new Rectangle(2,4);
            Shape square = new Square(4);
            Console.WriteLine(regtangle.Area); 
            Console.WriteLine(square.Area);
        }
    }
}
