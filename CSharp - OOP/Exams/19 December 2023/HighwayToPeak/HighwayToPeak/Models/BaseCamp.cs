using HighwayToPeak.Models.Contracts;

namespace HighwayToPeak.Models
{
    public class BaseCamp : IBaseCamp
    {
        private readonly List<string> residents;
        public BaseCamp()
        {
            this.residents = new List<string>();
        }
        public IReadOnlyCollection<string> Residents
        {
            get
            {
                List<string> sortedResidents = new List<string>(residents);
                sortedResidents.Sort();
                return sortedResidents;
            }
        }


        public void ArriveAtCamp(string climberName)
        {
            residents.Add(climberName);
        }

        public void LeaveCamp(string climberName)
        {
            residents.Remove(climberName);
        }
    }
}
