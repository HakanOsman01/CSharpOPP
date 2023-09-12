using System;

namespace _8._Most_Frequent_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int countFrequnce = 0;
            int mostFrequent = 0;
            int setStart = 0;
            int maxFrequnce = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                countFrequnce = 0;
                for (int j = 0; j< array.Length; j++)
                {
                    int nextNumber = array[j];
                    if (currentNumber == nextNumber)
                    {
                        countFrequnce++;
                    }
                }
                if (countFrequnce>mostFrequent)
                {
                    maxFrequnce = countFrequnce;
                    mostFrequent = array[i];
                    
                }
            }
            Console.WriteLine(mostFrequent);


        }
    }
}