using System;
using System.Linq;
namespace CondenseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] condenseArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int originalLenght=condenseArray.Length;
            for (int i = 1; i < originalLenght; i++)
            {
                int[]currentArray=new int[condenseArray.Length];
                for (int j = 0; j < currentArray.Length-1; j++)
                {
                    currentArray[j] = condenseArray[j] + condenseArray[j+1];

                }
                condenseArray = currentArray;
            }
            Console.WriteLine(condenseArray[0]);
        }
    }
}