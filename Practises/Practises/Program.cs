using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System;
using System.Linq;
using System.Globalization;

namespace Practises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Predicate<int>> predicates = new List<Predicate<int>>();

            int n = int.Parse(Console.ReadLine());

            int[] array = Enumerable.Range(1, n).ToArray();

            int[] dividers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n))
            .ToArray();
            foreach (var diveder in dividers)
            {
                predicates.Add(d => d % diveder == 0);
            }
            foreach (var num in array)
            {

                bool isDivisible = false;
                foreach (var pred in predicates)
                {
                    if (!pred(num))
                    {
                        isDivisible = true;
                        break;

                    }

                }
                if (!isDivisible)
                {
                    Console.Write($"{num} ");
                }

            }
            Console.WriteLine(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray().Select(x => x * 2));





        }


    }
}