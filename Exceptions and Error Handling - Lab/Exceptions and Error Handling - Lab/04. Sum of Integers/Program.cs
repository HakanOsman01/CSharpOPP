
using System.Runtime.InteropServices;

namespace _04._Sum_of_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentSum = 0;
            string[]elements=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
            
            foreach (string element in elements)
            {
               
                try
                {
                    int currentNumber =int.Parse(element);
                    currentSum+= currentNumber;
                   
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {currentSum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {currentSum}");

        }
    }
}