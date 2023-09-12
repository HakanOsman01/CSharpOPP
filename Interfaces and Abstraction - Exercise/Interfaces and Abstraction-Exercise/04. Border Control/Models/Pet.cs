


namespace _04._Border_Control.Models
{
    using Interfaces;
    public class Pet : IBirthable
    {
        public Pet(string name,string birthDay)
        {
            Name = name;
            Birthday = birthDay;
        }
        public string Name { get; private set; }
        public string Birthday { get; private set; }

       
    }
}
