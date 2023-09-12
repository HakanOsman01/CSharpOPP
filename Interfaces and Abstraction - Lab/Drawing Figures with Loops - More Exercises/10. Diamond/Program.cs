using System;
using System.Linq;
using System.Security;

namespace _10._Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

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
            Console.WriteLine(string.Join("", array));
            string firstLine=string.Join("",array);
            if(array.Length>3 && n%2!=0)
            {
                array[middlesStars] = '-';
                array[middlesStars - 1] = '*';
                array[middlesStars + 1] = '*';
                 
            }
            while (array[0]=='-' && array[array.Length-1]=='-')
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '*' && i-1>=0) 
                    {
                        array[i] = '-';
                        array[i - 1] = '*';
                        break;
                    }
                    
                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] == '*' && i + 1 < array.Length)
                    {
                        array[i] = '-';
                        array[i + 1] = '*';
                        break;
                    }
                }
                Console.WriteLine(string.Join("",array));
                
            }
            string currentLine=string.Join("",array);
            while (firstLine !=currentLine)
            {
                if (n%2!=0 && array[middlesStars-1]=='*' && array[middlesStars + 1] == '*')
                {
                    Console.WriteLine(firstLine);
                    break;
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '-' && i - 1 >= 0)
                    {
                        if (array[i - 1] == '*')
                        {
                            array[i] = '*';
                            array[i - 1] = '-';
                            break;

                        }
                       
                    }

                }
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] == '-' && i + 1 < array.Length)
                    {
                        if (array[i + 1] == '*')
                        {
                            array[i] = '*';
                            array[i + 1] = '-';
                            break;

                        }

                    }
                }
                Console.WriteLine(string.Join("", array));
                currentLine=string.Join("",array);

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