namespace DownUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int one = 1;
            GetDownUp(n,one);
        }

        static void GetDownUp(int n,int current)
        {
            if (current==n)
            {
                Console.Write($"{n}");
                return;
            }
            Console.Write($"{current} ");
            GetDownUp(n,current+1);
            Console.Write($" {current}");
        }
    }
}