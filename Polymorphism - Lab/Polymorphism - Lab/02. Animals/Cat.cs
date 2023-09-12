

using _02._Animals;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }

        public override string ExplainSelf()
        {
            StringBuilder sb = new StringBuilder();
             sb.AppendLine(base.ToString());
             sb.Append("MEEOW");
            return sb.ToString();
        }
    }
}
