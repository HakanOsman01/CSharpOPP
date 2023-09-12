namespace _10._Pairs_by_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array=Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int number=int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length-1; j++)
                {

                    if ((Math.Abs(array[i] - array[j]))==number)
                    {
                        count++;
                    }
                }

            }
            Console.WriteLine(count);
        }
    }
}