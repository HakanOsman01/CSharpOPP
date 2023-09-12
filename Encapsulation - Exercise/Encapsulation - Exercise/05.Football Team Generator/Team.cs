

namespace Football_Team_Generator
{
    public class Team
    {
        private string name { get; set; }
        private List<Player> players;
        
        public Team(string name="")
        {
            this.name = name;
            this.players = new List<Player>();
        }
        //public List<Player> Players { get { return players; } set {players.Add(value) } }
        public string Name => name;
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string namePlayer)

        {
            Player removePlayer=players.FirstOrDefault(p => p.Name == namePlayer);
            this.players.Remove(removePlayer);
        }
        public int Rating()
        {
                double rating = 0.00;
                foreach(var player in this.players) 
                {
                int endurance = player.Endurance;
                int passing = player.Passing;
                int shooting = player.Shooting;
                int sprint = player.Sprint;
                int driblling = player.Dribble;
                double average = (endurance + passing + shooting + sprint + driblling) / 5.00;
                rating += average;

                }
               
                

            
            return (int)Math.Ceiling(rating);
        }


    }
}
