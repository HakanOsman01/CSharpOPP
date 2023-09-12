


namespace Military_Elite.Core
{
    using Interfaces;
    using IO.Interfaces;
    using Military_Elite.Models;
    using Military_Elite.Models.Enums;
    using Military_Elite.Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly ICollection<ISoldier> allSoldiers;
        private Engine()
        {
            allSoldiers = new HashSet<ISoldier>();
        }
        public Engine(IReader reader,IWriter writer) :
            this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
           CreateSoldiers();
            this.PrintSoldiers();
        }
        private void CreateSoldiers()
        {
            string command = this.reader.ReadlLine();
            while (command != "End")
            {
                string[] cmdArgs = command
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string soldierType = cmdArgs[0];
                int id = int.Parse(cmdArgs[1]);
                string firstName = cmdArgs[2];
                string lastName = cmdArgs[3];
                ISoldier soldier = null;
                if (soldierType == "Private")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    soldier = new Private(id, firstName, lastName, salary);


                }
                else if (soldierType == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    ICollection<IPrivate> privates = this.FindPrivates(cmdArgs);
                    soldier = new LieutenantGeneral(id, firstName, lastName, salary, privates);
                }
                else if (soldierType == "Engineer")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corpsTex = cmdArgs[5];

                    bool isCorpsValid = Enum.TryParse<Corps>
                        (corpsTex, true, out Corps corps);
                    if (!isCorpsValid)
                    {
                        command = this.reader.ReadlLine();
                        continue;
                    }
                    ICollection<IRepair> repairs = this.CreateRepair(cmdArgs);
                    soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);


                }
                else if (soldierType == "Commando")
                {
                    decimal salary = decimal.Parse(cmdArgs[4]);
                    string corpsTex = cmdArgs[5];

                    bool isCorpsValid = Enum.TryParse<Corps>
                        (corpsTex, false, out Corps corps);
                    if (!isCorpsValid)
                    {
                        command = this.reader.ReadlLine();
                        continue;
                    }
                    ICollection<IMission> mission = this.CreateMissions(cmdArgs);
                    soldier = new Commando(id, firstName, lastName, salary, corps, mission);

                }
                else if (soldierType == "Spy")
                {
                    int codeNumber = int.Parse(cmdArgs[4]);
                    soldier = new Spy(id, firstName, lastName, codeNumber);

                }
                else
                {

                }
                this.allSoldiers.Add(soldier);
                command = this.reader.ReadlLine();
            }

        }
        private void PrintSoldiers()
        {
            foreach (ISoldier soldier in allSoldiers)
            {
                this.writer.WriteLine(soldier.ToString());

            }
        }
        private ICollection<IPrivate> FindPrivates(string[]cmdArgs)
        {
            int[] privateIds = cmdArgs.Skip(5)
                .Select(int.Parse)  
                .ToArray();
            ICollection<IPrivate> privates = new HashSet<IPrivate>();
            foreach (int privateId in privateIds)
            {
                IPrivate currentPrivate = (IPrivate)this
                    .allSoldiers.FirstOrDefault(s => s.Id == privateId);
                privates.Add(currentPrivate);

            }
            return privates;

        }
        private ICollection<IRepair> CreateRepair(string[]cmdArgs)
        {
            ICollection<IRepair> repairs = new HashSet<IRepair>();
            string[] repairsInfo = cmdArgs.Skip(6).ToArray();
            for (int i = 0; i < repairsInfo.Length; i+=2)
            {
                string partName = repairsInfo[i];
                int houseWorks = int.Parse(repairsInfo[i + 1]);
                IRepair repair=new Repair(partName, houseWorks);
                repairs.Add(repair);

            }
            return repairs;

        }
        private ICollection<IMission> CreateMissions(string[] cmdArgs)
        {
            ICollection<IMission> missions = new HashSet<IMission>();

            string[] missionsInfo = cmdArgs.Skip(6).ToArray();
            for (int i = 0; i < missionsInfo.Length; i += 2)
            {
                string codeName = missionsInfo[i];

                string stateText = missionsInfo[i + 1];

                bool isStateValid=Enum.TryParse<State>(stateText, false,out State state);

                if (!isStateValid)
                {
                    continue;
                }

                IMission mission = new Misson(codeName, state);
                missions.Add(mission);

            }
            return missions;
            
        }

    }
}
