namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tree<int> tree = new Tree<int>(7, new Tree<int>
            //    (19, new Tree<int>(1)
            //    , new Tree<int>(12)
            //    , new Tree<int>(31)), new Tree<int>(21), new Tree<int>(14
            //    , new Tree<int>(23), new Tree<int>(6))
            //    );
            //List<int>result= (List<int>)tree.OrderBfs();
            //Console.WriteLine(string.Join(" ",result));
            //List<int>result2=(List<int>)tree.GetByDfs();
            //Console.WriteLine(string.Join(" ",result2));
            //List<int> result3 = (List<int>)tree.GetLeafs();
            //Console.WriteLine(string.Join(" ",result3));
            int floors=int.Parse(Console.ReadLine());   
            int rooms=int.Parse(Console.ReadLine());
            for (int i = floors; i >=1; i--)
            {
                for (int j = 0; j < rooms; j++)
                {
                    if (i == floors)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                   

                }
                Console.WriteLine();

            }
        }
    }
}