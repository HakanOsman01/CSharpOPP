namespace Recursion
{
    
    internal class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
           int n=(int.Parse(Console.ReadLine()));
            Algorithm(n);
            Console.WriteLine(count);

        }
        //O(n^2);
        static void Algorithm(int n)
        {
            
            if (n == 0)
            {
                return;
            }
            count++;
            Algorithm(n - 1);
            Algorithm(n -  1);

        }
    }
}