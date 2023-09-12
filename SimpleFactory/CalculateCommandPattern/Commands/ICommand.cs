using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCommandPattern.Commands
{
    public interface ICommand
    {
        decimal Execute(decimal currentValue);
        decimal Unexecute(decimal currentValue);
    }
}
