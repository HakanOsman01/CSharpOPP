using System;
using System.Linq;
namespace _09._House
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());

            bool isEvenNum = false;
            if (n % 2 == 0)
            {
               isEvenNum = true;    

            }
            char[] array = FullArray(n);
            int middlesStars = n / 2;
            if (isEvenNum)
            {
               

                array[middlesStars] = '*';
                array[middlesStars - 1] = '*';
            }
            else
            {
                array[middlesStars] = '*';
                
            }
            Console.WriteLine(string.Join("",array));
            while (array.FirstOrDefault(s => s == '-') != '\0')
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]=='*' && i - 1 >= 0)
                    {
                        if (array[i-1]=='-') 
                        {
                            array[i - 1] = '*';
                            break;
                        }
                    }
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i]=='*' && i + 1 < array.Length)
                    {
                        if (array[i + 1] == '-')
                        {
                            array[i + 1] = '*';
                            break;
                        }
                    }
                }
                Console.WriteLine(string.Join("",array));
            }

           
            
           
            for (int i = 0; i < n/2; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n-2; j++)
                {
                    Console.Write("*");

                }
                Console.Write("|");
                Console.WriteLine();

            }
            
        }
        static char[] FullArray(int n)
        {
            char[] array = new char[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = '-';
            }
            return array;
        }
    }
}