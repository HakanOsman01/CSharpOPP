using System;
namespace _06._Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n-1; row++)
            {
                for (int i = 0; i < n-row-1; i++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < row+1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for(int row = n;row >0; row--)
            {
                for (int i = 0; i <n-row; i++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < row; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }
}