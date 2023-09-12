using System.Text;

namespace ProfesorGanchevSequnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int k=int.Parse(Console.ReadLine());
           List<string> list = new List<string>();
            list.Add("1");
            list.Add("121");
            for (int i = 2; i <= k-1; i++)
            {
                string sequnce = list[i - 1] +(i+1).ToString()+list[i-1];
                list.Add (sequnce);
            }
            StringBuilder sb=new StringBuilder();
            foreach (string s in list)
            {
                sb.Append(s);
            }
            Console.WriteLine(sb.ToString());

        }
    }
}