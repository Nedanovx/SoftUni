using MilitaryElite.Models.Interfaces;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWork)
        {
            PartName = partName;
            HoursWork = hoursWork;
        }

        public string PartName {get; private set;}

        public int HoursWork { get; private set; }
        public override string ToString()
        {
            return $"  Part Name: {PartName} Hours Worked: {HoursWork}";
        }
    }
}
