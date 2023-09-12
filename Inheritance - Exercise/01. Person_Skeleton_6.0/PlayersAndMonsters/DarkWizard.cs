using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public class DarkWizard : Wizard
    {
        private const int DeafaultMana = 100;
        
        public DarkWizard(string username, int level,int mana=DeafaultMana)
            :base(username,level,mana)
        {
            
        }
    }
}
