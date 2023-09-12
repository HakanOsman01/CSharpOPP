namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal("Pesho");
            string animalName = animal.Name;
            Console.WriteLine(animalName);
            Mammal mammal=new Mammal("Gosho");
            Console.WriteLine(mammal.Name);

        }
    }
}