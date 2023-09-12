namespace _5._Filter_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            List<Person> persons = ReadPersons(n);
            string condition=Console.ReadLine();
            int threshold = int.Parse(Console.ReadLine());
            Func<Person,int,bool>filterPeople=GetCondtionForFiltering(condition,threshold);
            persons=persons.Where(p=>filterPeople(p,threshold)).ToList();
            string format=Console.ReadLine();
            Action<Person> PrintPeople = PrintFormatPeple(format);
            foreach(Person person in persons)
            {
                PrintPeople(person);
            }
           
        }

        private static Action<Person> PrintFormatPeple(string format)
        {
            if(format== "name")
            {
                return (p)=>Console.WriteLine(p.Name);
            }
            else if (format == "age")
            {
                return (p) => Console.WriteLine(p.Age);
            }
            else
            {
                return (p) => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            
        }

        static Func<Person, int, bool> GetCondtionForFiltering(string condition, 
            int threshold)
        {
            if(condition== "younger")
            {
                return (p, age) => p.Age < threshold;
            }
            else
            {
                return (p, age) => p.Age >= threshold;
            }

        }

        private static List<Person> ReadPersons(int n)
        {
            List<Person> persons = new List<Person>();
           for (int i = 0; i < n; i++)
           {
                string[]info=Console.ReadLine()
                    .Split(", ");
                string name = info[0];
                int age = int.Parse(info[1]);
                persons.Add(new Person(name, age));
                
           }
           return persons;
        }
    }
    class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; private set; }

       
        public int Age { get; private set; }

    }
}