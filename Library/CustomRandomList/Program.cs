namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list= new RandomList();
            list.Add("pesho");
            list.Add("gosho");
            list.Add("Petko");
            string randomString=list.RandomString();
            Console.WriteLine(randomString);
            Console.WriteLine(list.Count);

        }
    }
}