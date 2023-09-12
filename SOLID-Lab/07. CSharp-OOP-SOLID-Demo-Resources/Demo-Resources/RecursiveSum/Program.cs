namespace RecursiveSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number=int.Parse(Console.ReadLine());
         
           Console.WriteLine(GetSumDigiths(number));
        }
        static int GetSumDigiths(int number)
        {
            int currentDigitnumber=number;
            if (currentDigitnumber==0)
            {
                return 0;
            }
            int sum = currentDigitnumber % 10 + GetSumDigiths(number / 10);
            return sum;
          


        }
    }
}