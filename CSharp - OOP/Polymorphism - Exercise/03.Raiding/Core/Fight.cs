using Raiding.Core.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Intefaces;

namespace Raiding.Core
{
    public class Fight : IFight
    {
        private IReader reader;
        private IWriter writer;
        private IHeroFactory createHero;

        private readonly ICollection<IBaseHero> raid;
        public Fight(IReader reader, IWriter writer, IHeroFactory createHero)
        {
            this.reader = reader;
            this.writer = writer;
            this.createHero = createHero;

            raid = new List<IBaseHero>();
        }

        public void Start()
        {
            int heroesCount = int.Parse(reader.ReadLine());

            while (heroesCount > raid.Count)
            {
                try
                {
                    raid.Add(CreateHero());
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(reader.ReadLine());

            foreach (var hero in raid)
            {
                writer.WriteLine(hero.CastAbility());
            }

            if (raid.Sum(x => x.Power) < bossPower)
            {
                writer.WriteLine("Defeat...");
            }
            else
            {
                writer.WriteLine("Victory!");
            }
        }

        private IBaseHero CreateHero()
        {
            string name = reader.ReadLine();
            string type = reader.ReadLine();
            return createHero.Create(name, type);
        }
    }
}
