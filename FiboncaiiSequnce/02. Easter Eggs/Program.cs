using System;
using System.Linq;
namespace _02._Easter_Eggs
{
    
    internal class Program
    {

        static int countWhiteSpaces = 0;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            GetEasterEggs(n);
            
        }

        static void GetEasterEggs(int n)
        {
            if(n == 0)
            {
                return;
            }
                int[]numbers= new int[n*2-1];          
                int countFirstHalf = 1;
                for (int i = 0; i < n; i++)
                {
                    numbers[i] = countFirstHalf;
                    countFirstHalf++;


                }

               
                int countSecondHalf = n-1;
                for (int i = countFirstHalf-1; i <numbers.Length; i++)
                {
                    numbers[i] = countSecondHalf;
                    countSecondHalf--;


                }
            string whiteSpaces = new string(' ', countWhiteSpaces);
            Console.WriteLine($"{whiteSpaces}{string.Join("",numbers)}");
            countWhiteSpaces++;
            GetEasterEggs(n - 1);
        }
    }
}