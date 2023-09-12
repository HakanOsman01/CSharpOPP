using System;
using System.Text;

namespace _08._Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int n=int.Parse(Console.ReadLine());
            Func<int, string> generateStarLine = (int count) =>
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count * 2; i++)
                {
                    sb.Append("*");

                }
                return sb.ToString();
            };
            string topAndDownLine = GetStarsLine(n, generateStarLine);
            Console.Write(topAndDownLine);
            Console.WriteLine();
            int middleGlases = (n - 1) / 2 ;
            for (int i = 1; i <= n-2; i++)
            {
                PrintGlases(n);
                if (middleGlases == i)
                {
                    string middle = new string('|', n);
                    Console.Write(middle);
                    PrintGlases(n);
                }
                else
                {
                    string spaceBetweenGlases = new string(' ', n);
                    Console.Write(spaceBetweenGlases);
                    PrintGlases(n);
                }
               
                
                Console.WriteLine();

            }
            Console.Write(topAndDownLine);

        }

        static string GetStarsLine(int n, Func<int, string> generateStarLine)
        {
            StringBuilder str=new StringBuilder();
            string stars=generateStarLine(n);
            str.Append(stars);
            for (int i = 0; i < n; i++)
            {
                str.Append(" ");
            }
            str.Append(stars);
            return str.ToString(); 
        }
        static void PrintGlases(int n)
        {
            Console.Write("*");
            for (int i = 1; i <= 2*n-2; i++)
            {
                Console.Write("/");
            }
            Console.Write("*");
        }
    }
   
}