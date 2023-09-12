using System;
namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] pascal = new int[n][];
            pascal[0] = new int[1];
            pascal[0][0] = 1;
            
            for (int row = 1; row < n; row++)
            {
                pascal[row] = new int[row+1];
                for (int col = 0; col < pascal[row].Length; col++)
                {

                    if (row == col)
                    {
                        pascal[row][col] = 1;
                    }
                    else if (row - 1 > 0 && col-1>=0)
                    {
                        pascal[row][col] = pascal[row-1][col-1]+pascal[row-1][col];
                    }
                    else
                    {
                        pascal[row][col] = 1;
                    }
               
                  
                   
                  
                }
            }
            PrintPascalTriangle(pascal);
           
        }
        static void PrintPascalTriangle(int[][] pascal)
        {

            for (int i = 0; i < pascal.GetLength(0); i++)
            {
                //string lineSpace = new string(' ', pascal.GetLength(0)-i);
                //Console.Write(lineSpace);
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    
                    Console.Write($"{pascal[i][j]} ");
                }
                Console.WriteLine();

            }
        }
    }
}