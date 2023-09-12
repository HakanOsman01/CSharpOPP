using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCommandPattern.Commands
{
    public abstract class Command : ICommand
    {
        public Command(int value,char operant)
        {
            this.Value = value;
            this.Operand = operant;

        }
        public int Value { get; set; }
        public char Operand { get; set; }
        public abstract decimal Execute(decimal currentValue);

        public abstract decimal Unexecute(decimal currentValue);
        public override string ToString()
        {
            return $"{Operand} {Value}";
        }
    }
}
