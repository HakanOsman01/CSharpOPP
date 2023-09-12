
namespace _04._Border_Control.Models
{
    using Interfaces;
    public class Citizen : IIedentife,IBirthable
    {
        public Citizen(string name,int age, string Id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Id;
            Birthday = birthday;

        }
        public string Id { get;private set; }   
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string Birthday { get; private set; }
    }
}
