using System;
namespace _02._Enter_Numbers

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int countIndex = 0;
            while(countIndex<10)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());
                    if (!(number > 1 && number < 100))
                    {
                        throw new ArgumentOutOfRangeException
                            ("Your number is not in range 1 - 100!");
                    }
                    array[countIndex++] = number;


                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName);
                }
            }

            Console.WriteLine($"{string.Join(", ",array)}");
        }
    }
}