using System;
using System.Linq;
using System.Collections.Generic;
namespace _1._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
           (Console.ReadLine().Split(" ").Select(int.Parse));
            string text=Console.ReadLine();
            string message = string.Empty;
            bool isIndexValid = false;
            foreach (int number in numbers)
            {
                int sum = GetSumDigiths(number);
                while (numbers.Count > message.Length)
                {
                   
                    if (text.Length < sum)
                    {
                        sum -= text.Length;

                        continue;
                    }
                    char letter = text[sum];
                    message = message + letter;
                    text = text.Remove(sum, 1);
                    break;
                }
               
            }
            Console.WriteLine(message);

        }
        static int GetSumDigiths(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}