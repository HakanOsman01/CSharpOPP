namespace CustomSortCompator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]array=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
           for (int i = 0; i < array.Length; i++)
           {
                int swamp = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                   
                    if (array[i]%2==0 && array[j]%2!=0)
                    {
                        array[i] = array[j];
                        array[j] = swamp;
                    }
                }

           }
            Console.WriteLine($"{string.Join(' ',array)}");
        }
        
    }
}