using Shopping_Spree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(";");
            string[]productTokens= Console.ReadLine().Split(";");
            List<string> personArgs = AddElements(personTokens);
            List<string>productArgs=AddElements(productTokens);
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            Dictionary<string, List<Product>> bagProducts = new Dictionary<string, List<Product>>();
            try
            {
                for (int i = 0; i < personArgs.Count; i++)
                {
                    if (string.IsNullOrEmpty(personArgs[i]))
                    {
                        continue;
                    }
                    string[] currentPerson = personArgs[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);
                    string name = currentPerson[0];
                    int money = int.Parse(currentPerson[1]);
                    Person newPerson = new Person(name, money);
                    persons.Add(newPerson);

                }
                for (int i = 0; i < productArgs.Count; i++)
                {
                    if (string.IsNullOrEmpty(productArgs[i]))
                    {
                        continue;
                    }

                    string[] currentProduct = productArgs[i]
                     .Split("=", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                    string nameProduct = currentProduct[0].TrimEnd();
                    int cost = int.Parse(currentProduct[1]);
                    Product product = new Product(nameProduct, cost);
                    products.Add(product);


                }

              
                for (int i = 0; i < persons.Count; i++)
                {
                    if (!bagProducts.ContainsKey(persons[i].Name))
                    {
                        bagProducts.Add(persons[i].Name, new List<Product>());
                    }
                }
               
                 
                
                 
                 
                
                 

                   
               

            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
                return;

            }
            string command = Console.ReadLine();
            while(command!= "END")
            {
                string[]tokens=command
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string customerName = tokens[0];
                string productName = tokens[1];
                Person person = persons.Find(p => p.Name == customerName);
                Product currentProduct = products.Find(p => p.Name == productName);
                if (bagProducts.ContainsKey(person.Name))
                {
                    if (person.Money >= currentProduct.Cost)
                    {
                        bagProducts[person.Name].Add(currentProduct);
                        person.Money-=currentProduct.Cost;  
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {currentProduct.Name}");
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in bagProducts)
            {
                List<string>listProducts=item.Value.Select(p => p.Name).ToList();
                if (listProducts .Count==0)
                {
                    Console.WriteLine($"{item.Key} - Nothing bought ");
                }
                else
                {
                    
                    Console.WriteLine($"{item.Key} - {string.Join(", ",listProducts)}");
                }
            }



        }
        static List<string> AddElements(string[]array)
        {
            List<string>list=new List<string>();
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            return list;
        }
    }
}
