using CalculateCommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateCommandPattern
{
    public class Calculator 
    {
        private List<ICommand>commands=new List<ICommand>();
        public decimal Result { get; set; }
        public void Execute(ICommand command)
        {
            commands.Add(command);
            Result = command.Execute(Result);

        }
        public override string ToString()
        {
            string result = "0";
           foreach (ICommand command in commands)
           {
                result += command.ToString();
           }
            result += $" = {Result}";
           return result;
          
        }

    }
}
