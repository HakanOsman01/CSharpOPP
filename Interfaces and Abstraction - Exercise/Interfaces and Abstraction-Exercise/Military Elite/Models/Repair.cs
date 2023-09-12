


namespace Military_Elite.Models
{
    using Interfaces;
    public class Repair : IRepair
    {
        public Repair(string partName,int hoursWork)
        {
            PartName = partName;
            HoursWork = hoursWork;
        }
        public string PartName { get;private set; }

        public int HoursWork { get;private set; }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWork}";
        }
    }
}
