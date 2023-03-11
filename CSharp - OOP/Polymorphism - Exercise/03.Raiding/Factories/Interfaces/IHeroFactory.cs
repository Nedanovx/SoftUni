using Raiding.Models.Intefaces;

namespace Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        IBaseHero Create(string name, string type);
    }
}
