namespace RomFIgRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[][] jagggedArray = new int[n][];
            jagggedArray[0] = new int[1];
            jagggedArray[0][0] = n;
            n -= 1;
            FullGaggedAray(n, jagggedArray);

        }
        static void FullGaggedAray(int n, int[][] jaggedArray)
        {
            if (n == 1)
            {
                return;
            }
            for (int row = 1; row < jaggedArray.GetLength(0); row++)
            {
                int[] line = new int[n];
                jaggedArray[row]=new int[line.Length];
                for (int col = 1; col < jaggedArray[row].Length; col++)
                {
                    if (row - 1 >= 0 && col - 1 >= 0)
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col - 1];
                    }
                    else if (row - 1 <= 0)
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col];
                    }
                   
                    else if(row-1<=0 && col-1>=0)
                    {
                        jaggedArray[row][col] = jaggedArray[row - 1][col-1];
                    }
                    
                }
                FullGaggedAray(n - 1, jaggedArray);

            }
        }
    }
}