using System;

namespace TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .ToArray();
            Func<string[], int, int[]> getSums = GetSum();
        }

        private static Func<string[], int, int[]> GetSum(string[] names, int number)
        {
            int[]asciiSum= new int[names.Length];
            int count = 0;
            foreach(string name in names)
            {
                int currentSum= 0;
                for(int i = 0; i < name.Length; i++)
                {

                    currentSum +=name[i];
                }
                asciiSum[count++] = currentSum;

            }
            return asciiSum;
        }
     
    }
}