using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArg[0];
                string pokemonName = cmdArg[1];
                string element = cmdArg[2];
                int health = int.Parse(cmdArg[3]);
                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                if (!trainers.ContainsKey(name))
                {
                    Trainer trainer = new Trainer(name);
                    trainers.Add(name, trainer);
                    trainers[name].AddPokem(pokemon);
                }
                else
                {
                    trainers[name].AddPokem(pokemon);
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Fire")
                {
                    foreach (var trainer in trainers.Values)
                    {
                        trainer.CheckPokemon(command);
                    }
                }
                else if (command == "Water")
                {
                    foreach (var trainer in trainers.Values)
                    {
                        trainer.CheckPokemon(command);
                    }
                }
                else if (command == "Electricity")
                {
                    foreach (var trainer in trainers.Values)
                    {
                        trainer.CheckPokemon(command);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var trainer in trainers.Values.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(trainer);
            }


        }
    }
}

