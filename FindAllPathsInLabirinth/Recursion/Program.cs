using System.Text.RegularExpressions;

namespace Recursion
{
    internal class Program
    {
        static int countCurrentRow = 1;
        static void Main(string[] args)
        {
          
            int n=int.Parse(Console.ReadLine());
            int count = n * 2 - 1;
            int[][] romb = new int[n * 2 - 1][];
            romb[0] = new int[1];
            romb[0][0] = n;
            DrawRombRecursive(romb, n,1,countCurrentRow);
            

        }
        static void DrawRombRecursive(int[][]romb,int n,int currentRow,int count)
        {
           if(n==currentRow)
           {
         
                return;
           }
            
            for (int i = currentRow; i <= romb.GetLength(0)/2; i++)
            {
                romb[countCurrentRow] = new int[i * 2+1];
                for (int j = 0; j < romb[countCurrentRow].Length;j++)
                {
                    if(j==0 || j == romb[countCurrentRow].Length-1)
                    {
                        romb[countCurrentRow][j] =n;
                    }
                    else
                    {
                        romb[countCurrentRow][j] = romb[countCurrentRow-1][j-1]-1;
                    }
                }
              

                DrawRombRecursive(romb,n,currentRow+1,count+1);
               



            }

          
        }

    }
}