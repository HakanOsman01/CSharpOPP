using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            string animalType = Console.ReadLine();
            while(animalType!= "Beast!")
            {
                try
                {
                    string[] animalInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    string nameAnimal = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);
                    Animal animal;
                    if (animalType == "Dog")
                    {
                        string gender = animalInfo[2];
                        animal = new Dog(nameAnimal, age, gender);
                    }
                    else if (animalType == "Frog")
                    {
                        string gender = animalInfo[2];
                        animal = new Frog(nameAnimal, age, gender);
                    }
                    else if (animalType == "Cat")
                    {
                        string gender = animalInfo[2];
                        animal = new Cat(nameAnimal, age, gender);
                    }
                    else if (animalType == "Kitten")
                    {
                        animal = new Kitten(nameAnimal, age);
                    }
                    else if (animalType == "Tomcat")
                    {
                        animal = new Tomcat(nameAnimal, age);
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid type!");
                    }
                    list.Add(animal);
                }
                catch(Exception) 
                {
                    throw new InvalidOperationException("Invalid input!");
                }

                animalType = Console.ReadLine();

            }
            foreach(Animal animal in list)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
