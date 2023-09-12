namespace Inheritance_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
          CustomRandomList list= new CustomRandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            Console.WriteLine(list.RandomString());
        }
    }
}