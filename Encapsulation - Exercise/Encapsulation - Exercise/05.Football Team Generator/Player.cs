
namespace Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;


        public Player(string name,int endurance,
            int spring,int dribble,int passing,int shooting)
        {
            Name=name;
            Endurance=endurance;
            Sprint=spring;
            Dribble=dribble;
            Passing=passing;
            Shooting=shooting;
        }
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }
        public int Endurance 
        {
            get
            {
                return endurance;
                
            }
            set
            {
                bool result = IsStatsInRange(value);
                if (result)
                {
                    endurance = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
            }
        }
        public int Dribble
        {
            get
            {
                return dribble;

            }
            set
            {
                bool result = IsStatsInRange(value);
                if (result)
                {
                    dribble = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }
            }
        }
        public int Sprint
        {
            get
            {
                return sprint;

            }
            set
            {
                bool result = IsStatsInRange(value);
                if (result)
                {
                    sprint = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }
            }
        }
        public int Passing
        {
            get
            {
                return passing;

            }
            set
            {
                bool result = IsStatsInRange(value);
                if (result)
                {
                    passing = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }
            }
        }
        public int Shooting
        {
            get
            {
                return shooting;

            }
            set
            {
                bool result = IsStatsInRange(value);
                if (result)
                {
                    shooting = value;
                }
                else
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100.");
                }
            }
        }
        private bool IsStatsInRange(int statsValue)
        {
            if(statsValue>=0 && statsValue <= 100)
            {
                return true;
            }
           
            return false;
        }
    }
}
