using MilitaryElite.Models.Enum;

namespace MilitaryElite.Models.Interfaces
{
    public interface ISpecialisedSoldier :IPrivate
    {
        Corps Corps { get; }
    }
}
