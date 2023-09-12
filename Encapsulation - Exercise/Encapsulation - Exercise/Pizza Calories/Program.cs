namespace Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] pizzaName = Console.ReadLine().Split(" ");
            string[] doughtTokens = Console.ReadLine().Split().ToArray();
            string flourType = doughtTokens[1];
            string bagingTechnique = doughtTokens[2];
            int weight = int.Parse(doughtTokens[3]);
            try
            {
               
                
                Dough dough = new Dough(flourType, bagingTechnique, weight);
                Pizza pizza = new Pizza(pizzaName[1], dough);
                string currentToping = Console.ReadLine();
                while(currentToping!= "END")
                {
                    string[]topingTokens=currentToping.Split(" "
                        ,StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string type = topingTokens[1];
                    int grams = int.Parse(topingTokens[2]);
                    Toppings topping=new Toppings(type, grams);
                    pizza.AddTopping(topping);
                    currentToping = Console.ReadLine();
                }
                if (pizza.ToppingsCount> 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                Console.WriteLine(pizza);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

          

        }
    }
}