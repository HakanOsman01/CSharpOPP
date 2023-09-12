


namespace _04._Border_Control.Engine
{
    using IO.Interdaces;
    using Interfaces;
    using _04._Border_Control.Models.Interfaces;
    using _04._Border_Control.Models;

    public class EngineClass : IEngine
    {
        private readonly IReadebly readebly;
        private readonly IPrintebale printebale;
        public EngineClass(IReadebly readebly, IPrintebale printebale)
        {
            this.readebly = readebly;
            this.printebale = printebale;
        }
       
        public void Run()
        {
           List<IIedentife>iedentives = new List<IIedentife>();
           List<IBirthable>birthables = new List<IBirthable>();
           string line=this.readebly.ReadLine();
            while(line != "End")
            {
                string[]tokens=line.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                if(tokens.Length == 3  && type=="Robot")
                {
                    string model = tokens[1];
                    string id = tokens[2];
                    iedentives.Add(new Robot(model,id));
                }
                else if (tokens.Length==3 && type=="Pet")
                {
                    string name = tokens[1];
                    string birtday = tokens[2];
                    birthables.Add(new Pet (name,birtday));
                }
                else
                {
                    string name = tokens[1];
                    int age = int.Parse(tokens[2]);
                    string id= tokens[3];
                    string birtday = tokens[4];
                    birthables.Add(new Citizen(name, age, id, birtday));
                    iedentives.Add(new Citizen(name,age,id, birtday));
                }
                line=this.readebly.ReadLine();
                

            }
            string lastIdNumbers = this.readebly.ReadLine();
            foreach (var item in birthables)
            {
                bool isEndWith = item.Birthday.EndsWith(lastIdNumbers);
                if (isEndWith)
                {
                    this.printebale.PrintId(item.Birthday);
                }
            }
        }
    }
}
