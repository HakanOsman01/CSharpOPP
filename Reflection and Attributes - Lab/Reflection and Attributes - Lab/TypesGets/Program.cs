namespace TypesGets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Type type=typeof(string);
            Type typeStudent=student.GetType();
            Person person = new Person();
            Student obj=type.GetType().IsAssignableFrom(person);
            Console.WriteLine();


        }
    }
    class Student: Person
    {
        public int Name { get; set; }
        public int Age { get; set; }
        public string  EGN{ get; set; }

    }
    class Person
    {

    }
   
}