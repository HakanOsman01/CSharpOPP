namespace _07.Debugging_Technigue
{
    public class Program
    {
        static void Main(string[] args)
        {

         int n=int.Parse(Console.ReadLine());
            PrintRecurursionly(n);
        }

        static void PrintRecurursionly(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine("I Print !!! -> {0}",n);
            PrintRecurursionly(n - 1);


        }
    }
}