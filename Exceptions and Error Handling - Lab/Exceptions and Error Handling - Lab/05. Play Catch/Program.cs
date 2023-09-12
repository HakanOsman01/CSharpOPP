
using System;
namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]numbers=Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int countExceptions = 0;
            ArgumentOutOfRangeException argumentOutOfRangeException = 
                new ArgumentOutOfRangeException("The index does not exist!");
            while (countExceptions < 3)
            {
                string[] cmdArgs = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();
                string typeCommand = cmdArgs[0];

                try
                {
                    switch (typeCommand)
                    {
                        case "Replace":
                            int replaceIndex = int.Parse(cmdArgs[1]);
                            int element = int.Parse(cmdArgs[2]);
                            bool isValidReplaceIndex = CheckIndexIsValid(numbers, replaceIndex);
                            if(isValidReplaceIndex)
                            {
                                throw argumentOutOfRangeException;
                            }
                            numbers[replaceIndex] = element;
                            break;
                        case "Print":
                            int startIndex = int.Parse(cmdArgs[1]);
                            int endIndex = int.Parse(cmdArgs[2]);
                            bool isValidStartIndex=CheckIndexIsValid(numbers, startIndex);
                            bool isValidEndIndex = CheckIndexIsValid(numbers, endIndex);
                            if( isValidStartIndex || isValidEndIndex )
                            {
                                throw argumentOutOfRangeException;
                            }
                            PrintInRange(numbers, startIndex, endIndex);
                            break;
                        case "Show":
                            int showIndex = int.Parse(cmdArgs[1]);
                            bool isValidShowIndex=CheckIndexIsValid(numbers, showIndex);
                            if (isValidShowIndex)
                            {
                                throw argumentOutOfRangeException;
                            }
                            Console.WriteLine($"{numbers[showIndex]}");
                            break;



                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    countExceptions++;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName);
                    countExceptions++;
                }

            }
            Console.WriteLine($"{string.Join(", ",numbers)}");
        }
        static bool CheckIndexIsValid(int[]numbers,int index)
        {
            return index<0 || index>=numbers.Length;
        }
        static void PrintInRange(int[]numbers, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i == end)
                {
                    Console.Write($"{numbers[i]}");
                    continue;
                }
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine();
        }
      
    }
}