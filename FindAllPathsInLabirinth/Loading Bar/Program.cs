namespace Loading_Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            Console.Write($"{n}% ");
            string loadingBar = GetLoadingBar(n);
            if (n == 100)
            {
                Console.Write("Complete!");
                Console.WriteLine(loadingBar);
            }
            else
            {
                Console.Write(loadingBar);
                Console.WriteLine();
                Console.WriteLine("Still loading...");
            }
        }
        static string GetLoadingBar(int n)
        {

            string loadingBar = "[..........]";
            int count = 1;
            for (int currentBar = n; currentBar>0; currentBar-=10)
            {
                loadingBar = loadingBar.Remove(count, 1);
                loadingBar = loadingBar.Insert(count, "%");
                count++;
            }
            return loadingBar;
        }
    }
}