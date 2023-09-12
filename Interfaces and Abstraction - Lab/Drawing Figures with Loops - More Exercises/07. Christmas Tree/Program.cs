using System;
namespace _07._Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            PrintWhiteSpaces(n+1);
            Console.Write("|");
            PrintWhiteSpaces(n);
            Console.WriteLine();
            bool[]isStarThere = new bool[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j==isStarThere.Length-i-1)
                    {
                        isStarThere[j] = true;
                    }
                }
                PrintStars(n,isStarThere);
                Console.Write(" | ");
                for (int k = isStarThere.Length-1; k >= 0; k--)
                {
                    if (!isStarThere[k])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();

            }


        }
        static void PrintWhiteSpaces(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(' ');
            }
        }
        static void PrintStars(int n, bool[] isStarThere)
        {
            for (int j = 0; j < n; j++)
            {
                if (!isStarThere[j])
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }

        }
    }
}