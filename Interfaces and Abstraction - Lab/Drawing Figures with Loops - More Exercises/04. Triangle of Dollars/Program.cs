using System;

namespace _04._Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangeleDollar(n,n);
        }

        
        static void PrintTriangeleDollar(int n,int index)
        {
            if (index == 0)
            {
                return;
            }
           
            PrintTriangeleDollar(n,index-1);
            string currentDollars = new string('$', index);
            char[]array=new char[currentDollars.Length];
            for (int i = 0; i < currentDollars.Length; i++)
            {
                array[i] = currentDollars[i];
            }
            Console.WriteLine(string.Join(" ",array));
           
            
        }
    }
}