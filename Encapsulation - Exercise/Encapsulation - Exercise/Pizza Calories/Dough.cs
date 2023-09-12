

namespace Pizza_Calories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        // White - 1.5
        // Wholegrain - 1.0
        // Crispy - 0.9
        // Chewy - 1.1
        // Homemade - 1.0
        public Dough(string flourType,string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            
        }
        public string FlourType 
        {
            //white or wholegrain
            get
            {
                return flourType;
            }
            private set
            {
                switch (value)
                {
                    case "White":
                        flourType=value;
                        break;
                    case "Wholegrain":
                        flourType=value;
                        break;
                    default:
                        throw new ArgumentException("Invalid type of dough.");

                        
                }
            }
        }
        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            private set
            {
                switch (value)
                {
                    case "Crispy":
                        bakingTechnique = value;
                        break;
                    case "Chewy":
                        bakingTechnique = value;
                        break;
                    case "Homemade":
                        bakingTechnique = value;
                        break;
                    default:
                        throw new ArgumentException($"Invalid type of {nameof(this.BakingTechnique)}.");
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
                if(value>=1 && value <= 200)
                {
                    weight = value;
                }
                else
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");

                }
            }
        }

        public double CalculateCalories()
        {
            double caloriesInBackingTehnique = 0.00;
            double caloriesInFlourType = 0.00;
            if(this.BakingTechnique== "Crispy")
            {
                caloriesInBackingTehnique = 0.9;
            }
            else if(this.BakingTechnique== "Chewy")
            {
                caloriesInBackingTehnique = 1.1;
            }
            else
            {
                caloriesInBackingTehnique = 1.0;
            }
            if (this.FlourType == "White")
            {
                caloriesInFlourType = 1.5;
            }
            else
            {
                caloriesInFlourType=1.0;
            }
            double totalCalories = ((weight * 2) * caloriesInFlourType) * caloriesInBackingTehnique;
            return totalCalories;

        }

    }
}
