namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>guests=Console.ReadLine().Split(" ").ToList();
            string command=Console.ReadLine();
          
            while(command!= "Party!")
            {
                string[] cmdTokens = command.Split(" ");
                string type = cmdTokens[0];
                Func<string, bool> filter = GetFilter(cmdTokens[1], cmdTokens[2]);
                switch (type)
                {
                    
                    case "Remove":
                       
                        guests.RemoveAll(g=> filter(g));
                        break;
                    case "Double":
                       List<string>findGuest=guests.FindAll(g=> filter(g));
                        guests.InsertRange(0,findGuest);
                        break;


                }
                command = Console.ReadLine();

            }
            if(guests.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ",guests)} are going to the party!");

            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

        }

        static Func<string, bool> GetFilter(string type, string criterial)
        {
            if(type=="StartsWith")
            {
                return s=>s.StartsWith(criterial);
            }
            else if(type== "EndsWith")
            {
                return s=>s.EndsWith(criterial);
            }
            else
            {
                return s => s.Length == int.Parse(criterial);
            }
          
        }
    }
}