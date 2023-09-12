using System.Net.Sockets;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string matchStr=Console.ReadLine();
            string text=Console.ReadLine();
            int index = text.IndexOf(matchStr);
            while (index!=-1)
            {
                
                text = text.Remove(index, matchStr.Length);
                index = text.IndexOf(matchStr);
            }
            Console.WriteLine(text);
            
        }
    }
}