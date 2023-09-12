using System;
namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                int squareRoot=(int)Math.Sqrt(number);
                Console.WriteLine(squareRoot);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }

        }
    }
}