namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonachi = CalculateFiboncci(n);
            Console.WriteLine(fibonachi);
        }

        private static int CalculateFiboncci(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            if (n == 3)
            {
                return 3;
            }
            int fibonachi = CalculateFiboncci(n-1)+CalculateFiboncci(n-2)+CalculateFiboncci(n-3);
            return fibonachi;
        }
    }
}