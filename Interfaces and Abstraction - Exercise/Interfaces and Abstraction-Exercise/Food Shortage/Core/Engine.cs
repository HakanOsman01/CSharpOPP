

namespace Food_Shortage.Core
{
    using Food_Shortage.Models;
    using Food_Shortage.Models.Interfaces;
    using Interfaces;

    public class Engine : IEngine
    {
        public Engine()
        {
            this.buyers=new Dictionary<string, IBuyer> ();
        }
        private Dictionary<string, IBuyer> buyers;
        public void Run()
        {
           
            int numberOfPeople=int.Parse(Console.ReadLine());

            for (int curPeople = 1; curPeople <= numberOfPeople; curPeople++)
            {
                string[]tokens=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                if (tokens.Length == 3)
                {
                    string group = tokens[2];
                    IBuyer rebel = new Rebel(name, age, group);
                    AddBuyers(name, rebel);

                }
                else
                {
                    string id = tokens[2];
                    string birthDay = tokens[3];
                    IBuyer citizen=new Citizen(name, age, id,birthDay);
                    AddBuyers(name, citizen);

                }
               

            }
            string currentHuman = Console.ReadLine();
            while (currentHuman != "End")
            {
                BoughtFood(currentHuman);
                currentHuman = Console.ReadLine();
            }
            int totalAmountFood = GetTotalAmountFood();
            Console.WriteLine(totalAmountFood);

        }
        private void AddBuyers(string name, IBuyer human)
        {
            if (!this.buyers.ContainsKey(name))
            {
                buyers.Add(name,human);
            }

        }
        private void BoughtFood(string name)
        {
            if(this.buyers.ContainsKey(name))
            {
                buyers[name].BuyFood();
            }
        }
        private int GetTotalAmountFood()
        {
            int total = 0;
            foreach (var item in buyers)
            {
                total += item.Value.Food;
            }
            return total;
        }
    }
}
