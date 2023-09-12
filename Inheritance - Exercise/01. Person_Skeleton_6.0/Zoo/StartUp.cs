using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Snake snake = new Snake("Piton");
            Console.WriteLine($"The snake name is {snake.Name}");
            Console.WriteLine("The snake name is {0}",snake.Name);
        }
    }
}