using Raiding.Factories.Interfaces;
using Raiding.Models;
using Raiding.Models.Intefaces;

namespace Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {       
        public IBaseHero Create(string name, string type)
        {
           switch (type)
            {
                case "Druid":
                    return new Druid(name);
                case "Paladin":
                    return new Paladin(name);                   
                case "Rogue":
                    return new Rogue(name);                   
                case "Warrior":
                    return new Warrior(name);                  
                    default:
                    throw new ArgumentException("Invalid hero!");
            }
        }
    }
}
