
namespace Pizza_Calories
{
    public class Toppings
    {
        private string typeTopping;
        private int weight;
        public Toppings(string typeTopping,int weight)
        {
            TypeTopping= typeTopping;
            Weight= weight;
        }
        public string TypeTopping 
        {
            get
            {
                return typeTopping;
            }
            private set
            {
                switch(value)
                {
                    case "Meat":
                        typeTopping=value; 
                        break;
                    case "Veggies":
                        typeTopping = value;
                        break;
                    case "Cheese":
                        typeTopping = value;
                        break;
                    case "Sauce":
                        typeTopping = value;
                        break;
                    default:
                        throw new ArgumentException($"Cannot place {value} on top of your pizza.");

                }
            }
        }
        public int Weight 
        {
            get
            {
                return weight;
            }
            private set
            {
                if(value>=1 && value <= 50)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException($"{this.TypeTopping} weight should be in the range [1..50].");
                }
            }
        }
        public double CalcuateColoriesToppings()
        {
            double caloriesInTopping = 0.0;
            if (this.TypeTopping == "Meat")
            {
                caloriesInTopping = 1.2;
            }
            else if (this.TypeTopping == "Veggies")
            {
                caloriesInTopping = 0.8;
            }
            else if (this.TypeTopping == "Cheese")
            {
                caloriesInTopping = 1.1;
            }
            else
            {
                caloriesInTopping = 0.9;
            }
            double totalCalories = (this.Weight * 2) * caloriesInTopping;
            return totalCalories;
        }
    }
}
