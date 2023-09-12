


namespace Explicit_Interfaces.Models
{
    using Explicit_Interfaces.IO.Interfaces;
    using Interfaces;
    using System.Threading.Channels;

    public class Citizen : IResident,IPerson
    {
        
        public Citizen(string name,string contry,int age)
        {
            
            this.Name = name;
            this.Contry = contry;
            this.Age = age;
        }
        public string Name { get;private set; }

        public string Contry { get;private set; }

        public int Age { get; private set; }

        string IResident.GetName() =>$"Mr/Ms/Mrs {this.Name}";

        string IPerson.GetName() => $"{this.Name}";
       
    }
}
