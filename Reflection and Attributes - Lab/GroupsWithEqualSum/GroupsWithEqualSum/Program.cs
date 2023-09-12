namespace GroupsWithEqualSum
{
    internal class Program
    {
        static int currentSum = 1;
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int sum = GetSumOfDigiths(n);
            if (currentSum == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(currentSum);

            }
           

        }

        static int GetSumOfDigiths(int n)
        {
            if (n == 0)
            {
                return 0;
            }
           
            if ((n % 10)%2==0)
            {
                currentSum *= n % 10;
            }
            GetSumOfDigiths(n / 10);
            return 0;
        }
    }
}