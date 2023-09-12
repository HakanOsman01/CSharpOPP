using System;
namespace _05._Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           DrawTopAndDownLine(n);
           
            for (int i = 0; i < n-2; i++)
            {
                DrawMiddle(n);
                Console.WriteLine();
            }
            DrawTopAndDownLine(n);
        }
        static void DrawTopAndDownLine(int n)
        {
            Console.Write("+ ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("+");
            Console.WriteLine();
        }
        static void DrawMiddle(int n)
        {
            Console.Write("| ");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.Write("|");

        }
    }
}