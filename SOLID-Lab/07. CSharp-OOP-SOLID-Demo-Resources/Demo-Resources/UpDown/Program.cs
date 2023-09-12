namespace UpDown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            UpDown(n);
        }
        static void UpDown(int n)
        {
            if (n == 1)
            {
                Console.Write(n);
                return;
            }
            Console.Write($"{n} ");
            UpDown(n-1);
            Console.Write($" {n}");
        }
    }
}