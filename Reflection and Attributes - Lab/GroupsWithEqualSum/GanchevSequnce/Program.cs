using System.Text;

namespace GanchevSequnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StringBuilder sb=new StringBuilder();
            string sequnce = "121";
            int n=int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else if (n == 2)
            {
                Console.WriteLine("121");
            }
            else
            {
                //string currentState = string.Empty;
                sb.Append(sequnce);
                for (int i = 3; i <=n; i++)
                {
                    sb.Append(i.ToString());
                    sb.Append(sequnce);
                    sequnce=sequnce+i.ToString();

                }
                Console.WriteLine(sb.ToString());
            }


        }
    }
}