using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Trainer
    {
        
        public Trainer(string name)
        {
            Name = name;
            pokemons = new List<Pokemon>();
            Badges = 0;
        }

        public string Name { get; set; }

        public List<Pokemon> pokemons;

        public int Badges { get; set; }
        public void AddPokem(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }

        public void CheckPokemon(string element)
        {
            foreach (var pokemon in pokemons)
            {
                if (pokemon.Element == element)
                {
                    Badges++;
                    break;
                }
                else
                {
                    pokemon.Health -= 10;
                }
            }
            for (int i = 0; i < pokemons.Count; i++)
            {
                Pokemon pokemon = pokemons[i];
                if (pokemon.Health <= 0)
                {
                    pokemons.Remove(pokemon);
                }
            }

        }

        public override string ToString()
        {
            return $"{Name} {Badges} {pokemons.Count}";
        }
    }
}
