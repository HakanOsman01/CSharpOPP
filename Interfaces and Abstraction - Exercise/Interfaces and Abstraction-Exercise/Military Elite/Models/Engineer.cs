


namespace Military_Elite.Models
{
    using Enums;
    using Interfaces;
    using System.Text;

    public class Engineer : SpecialisedSoldier,IEngineer
    {
        private readonly ICollection<IRepair> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, 
            Corps corps,ICollection<IRepair>repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = repairs;
        }

        public IReadOnlyCollection<IRepair> Repairs
            =>(IReadOnlyCollection<IRepair>)this.repairs;
        public override string ToString()
        {
            StringBuilder str= new StringBuilder();
            str.AppendLine(base.ToString())
            .AppendLine("Repairs:");

            foreach (IRepair repair in this.repairs)
            {
                str.AppendLine(repair.ToString());
            }
           return str.ToString().TrimEnd();
            
        }
    }
}
