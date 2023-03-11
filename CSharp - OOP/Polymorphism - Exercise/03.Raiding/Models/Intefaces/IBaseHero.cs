namespace Raiding.Models.Intefaces
{
    public interface IBaseHero
    {
        public string Name { get; }
        public int Power { get; }

         string CastAbility();
    }
}
