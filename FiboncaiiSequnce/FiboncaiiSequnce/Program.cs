using System;
using System.Collections.Generic;
using System.Linq;
namespace FiboncaiiSequnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int>simpleNumbers= new List<int>();
          int N=int.Parse(Console.ReadLine());
          int M=int.Parse(Console.ReadLine());
            
          for (int i = N; i <= M; i++)
          {
                bool isSimpleNumber = true;
                int currentDivideNumber = 2;
                while (i > currentDivideNumber)
                {
                    if (i % currentDivideNumber == 0 )
                    {
                        isSimpleNumber = false;
                        break;
                    }
                    currentDivideNumber++;
                }
                if (isSimpleNumber && i!=1)
                {
                    simpleNumbers.Add(i);
                }


          }
            Console.WriteLine($"{string.Join(" ",simpleNumbers)}");
            Console.WriteLine($"The total number of prime numbers " +
                $"between {N} to {M} is {simpleNumbers.Count}");
        }
    }
}