using System;
using System.Linq;

namespace _3._Last_K_Numbers_Sums_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k=int.Parse(Console.ReadLine());
            int[]sequnce=new int[n];
            sequnce[0] = 1;
            for(int i=1; i<sequnce.Length; i++)
            {
                int sum = 0;
                if (k>i)
                {
                    for(int j=i; j>=0; j--)
                    {
                        int currentElement = sequnce[j];
                        sum+= currentElement;
                    }
                    sequnce[i] = sum;
                }
                else
                {
                    int count = k;
                    int j = i;
                    while(count!=0)
                    {
                        int currentElement = sequnce[--j];
                        sum+= currentElement;
                        count--;
                    }
                    sequnce[i] = sum;
                }
            }
            Console.WriteLine($"{string.Join(' ',sequnce)}");
        }
    }
}