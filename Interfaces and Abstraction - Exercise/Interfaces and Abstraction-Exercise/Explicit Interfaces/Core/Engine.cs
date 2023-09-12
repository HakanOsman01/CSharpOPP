


namespace Explicit_Interfaces.Core
{
    using Explicit_Interfaces.IO;
    using Explicit_Interfaces.IO.Interfaces;
    using Explicit_Interfaces.Models;
    using Explicit_Interfaces.Models.Interfaces;
    using Interfaces;
    public class Engine : IEngine
    {
        public void Run()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            string line= reader.ReadLine();
            while(line!= "End")
            {
                string[]tokens= line
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                string contry= tokens[1];

                int age = int.Parse(tokens[2]);

                IPerson person = new Citizen(name, contry, age);

                IResident resident = new Citizen(name, contry, age);

                writer.WriteLine(person.GetName());

                writer.WriteLine(resident.GetName());

              

                line = reader.ReadLine();

            }
        }
    }
}
