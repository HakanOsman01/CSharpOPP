



namespace Military_Elite.Models
{
    using Interfaces;
    using System.Text;

    public class LieutenantGeneral : Private,ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, 
            decimal salary,ICollection<IPrivate>privates) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = privates ;
        }

        public IReadOnlyCollection<IPrivate> Privates
            => (IReadOnlyCollection<IPrivate>)this.privates;
        public override string ToString()
        {
           StringBuilder stringBuilder=new StringBuilder();
            stringBuilder.AppendLine(base.ToString())
                .AppendLine($"Privates:");
            foreach (IPrivate priv in privates)
            {
                stringBuilder.AppendLine(priv.ToString());
            }
            return stringBuilder.ToString().TrimEnd();

        }

    }
}
