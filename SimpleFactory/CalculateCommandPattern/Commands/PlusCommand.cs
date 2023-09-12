using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCommandPattern.Commands
{
    public class PlusCommand : Command
    {
        public PlusCommand(int value) 
            : base(value,'+')
        {
            
        }
        public override decimal Execute(decimal currentValue)
        {
            return currentValue + Value;
        }

        public override decimal Unexecute(decimal currentValue)
        {
            return currentValue - Value;
        }
    }
}
