

namespace Pizza_Calories
{
    public class Pizza
    {
        private string name;
        private List<Toppings> toppings;
        private Dough dough;
        public Pizza(string name,Dough dough)
        {
            this.Name= name;
            this.dough = new Dough(dough.FlourType, dough.BakingTechnique, dough.Weight);
            this.toppings = new List<Toppings>();

        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if(value.Length>=1 && value.Length <= 15)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }


            }
        }
        public int ToppingsCount =>toppings.Count;
        public void AddTopping(Toppings topping)
        {
            this.toppings.Add(topping);
           
        }
       private double CalculateCalories()
       {
            double calories = 0.0;
            double doughtCalories = dough.CalculateCalories();
            double totalToppingsCalories = 0.0;
            foreach (var item in toppings)
            {
                totalToppingsCalories += item.CalcuateColoriesToppings();

            }
            return calories = totalToppingsCalories + doughtCalories;
       }
        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateCalories():f2} Calories.";
        }


    }
}
