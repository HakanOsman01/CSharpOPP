using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood) 
            : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append("DJAAF");
            return sb.ToString();
        }
    }
}
