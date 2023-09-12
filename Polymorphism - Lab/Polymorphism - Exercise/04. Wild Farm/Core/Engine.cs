



namespace _04._Wild_Farm.Core
{
    using _04._Wild_Farm.Models;
    using Interfaces;
    public class Engine : IEngine
    {
        public void Run()
        {
            string line=Console.ReadLine();
            List<string> informationForAnimals = new List<string>();
            while(line != "End")
            {
                string[] infoAnimals = 
               line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
                string animalType = infoAnimals[0];
                string animalName = infoAnimals[1];
                double weight = double.Parse(infoAnimals[2]);
                Feline feline = null;
                Bird bird = null;
                Mammal mammal = null;
                //string name, double weight, int foodEaten, string livingRegion-cat
                //string name, double weight, int foodEaten, string livingRegion-tiger
                switch (animalType)
                {
                    case "Cat":
                        feline = new Cat(animalName, weight, 0, infoAnimals[3], infoAnimals[4]);
                        break;
                    case "Tiger":
                        feline = new Tiger(animalName, weight, 0, infoAnimals[3], infoAnimals[4]);
                        break;
                    case "Dog":
                        mammal=new Dog(animalName,weight, 0, infoAnimals[3]);
                        break;
                    case "Mouse":
                        mammal=new Mouse(animalName,weight,0, infoAnimals[3]);
                        break;
                    case "Owl":
                        double wingSizeOwl = double.Parse(infoAnimals[3]);
                        bird = new Owl(animalName, weight, 0, wingSizeOwl);
                        break;
                    case "Hen":
                        double wingSizeHen = double.Parse(infoAnimals[3]);
                        bird = new Hen(animalName, weight, 0, wingSizeHen);
                        break;
                    default:
                        Console.WriteLine("Invalid animal!!!");
                        break;


                }
                Food food = null;
                string[] foodInfo = Console.ReadLine().Split(' ');
                string foodType = foodInfo[0];
                int quantityFood = int.Parse(foodInfo[1]);
                switch (foodType)
                {
                    case "Vegetable":
                        food = new Vegetable(quantityFood);
                        break;
                    case "Fruit":
                        food = new Fruit(quantityFood);
                        break;
                    case "Meat":
                        food = new Meat(quantityFood);
                        break;
                    case "Seeds":
                        food = new Seeds(quantityFood);
                        break;
                    default:
                        Console.WriteLine("Invalid type food!!!");
                        break;
                }
                if (feline != null)
                {
                   
                    feline.Eat(food);
                    informationForAnimals.Add(feline.ToString());
                }
                else if(bird != null)
                {
                    bird.Eat(food);
                    informationForAnimals.Add(bird.ToString());
                }
                else
                {
                    mammal.Eat(food);
                    informationForAnimals.Add(mammal.ToString());
                }
                line = Console.ReadLine();

            }
            PrintInfo(informationForAnimals);
        }
        private void PrintInfo(List<string> informationForAnimals)
        {
            foreach (var animal in informationForAnimals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
