using System.Xml.Linq;

namespace Football_Team_Generator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, Team>> teams = 
                new Dictionary<string, Dictionary<string, Team>>();
            againTry:
            string command = Console.ReadLine();
            try
            {
                while (command != "END")
                {
                    string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                    string type = tokens[0];
                    string name = tokens[1];
                    switch (type)
                    {
                        case "Team":
                            if (!teams.ContainsKey(name))
                            {
                                teams.Add(name, new Dictionary<string, Team>());
                                
                            }
                            break;
                        case "Add":
                            AddPlayer(teams, tokens);
                            break;
                        case "Remove":
                            RemovePlayer(teams, tokens);
                            break;
                        case "Rating":
                            Team ratingTeam = new Team();
                            bool isFound= false;
                           if(teams.ContainsKey(name))
                           {
                                foreach (var item1 in teams)
                                {
                                    foreach (var item2 in item1.Value)
                                    {
                                        if (item2.Value.Name == name)
                                        {
                                            ratingTeam = item2.Value;
                                            isFound= true;
                                             break;
                                        }
                                    }
                                    if (isFound)
                                    {
                                        break;
                                    }
                                }
                                
                                Console.WriteLine($"{name} - {ratingTeam.Rating()}");
                           }
                           else 
                           {
                                throw new ArgumentException($"Team {name} does not exist.");
                           }
                            break;
                    }
                   
                    command = Console.ReadLine();

                    
                }


            }
            
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                goto ineligible;
            }
           ineligible:
            if (command == "END")
            {
                return;
            }
            goto againTry;



        }
        static void AddPlayer(Dictionary<string, Dictionary<string, Team>> teams, string[] tokens)
        {
            string name = tokens[1];
            string playerName = tokens[2];
            int endurance = int.Parse(tokens[3]);
            int sprint = int.Parse(tokens[4]);
            int dribble = int.Parse(tokens[5]);
            int passing = int.Parse(tokens[6]);
            int shooting = int.Parse(tokens[7]);
            if (teams.ContainsKey(name))
            {
                if (!teams[name].ContainsKey(playerName))
                {
                    Team newTeam = new Team(name);
                    Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                    newTeam.AddPlayer(player);
                    teams[name][playerName] = newTeam;
                    //newTeam.AddPlayer
                }

            }
            else
            {
                throw new ArgumentException($"Team {name} does not exist.");
            }
        }
        static void RemovePlayer(Dictionary<string, Dictionary<string, Team>> teams, string[] tokens)

        {
            string name = tokens[1];
            string removePlayer = tokens[2];
            if (teams.ContainsKey(name))
            {
                if (teams[name].ContainsKey(removePlayer))
                {
                    Team currentRemoveTeam = teams[name][removePlayer];

                    currentRemoveTeam.RemovePlayer(removePlayer);
                }
                else
                {
                    throw new ArgumentException($"Player {removePlayer} is not in {name} team.");
                }
            }
        }
      
    }
}