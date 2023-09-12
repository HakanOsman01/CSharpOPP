using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters.Knights
{
    public class DarkKnight : Knight
    {
        private const int DeafaultStamina= 100;
        public DarkKnight(string username, int level,int stamina=DeafaultStamina) 
            : base(username, level,stamina)
        {

        }
    }
}
