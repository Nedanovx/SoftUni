using System;
using System.Collections.Generic;

namespace _06._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, int> heroesAndHp = new Dictionary<string, int>();
            Dictionary<string, int> HeroesAndMana = new Dictionary<string, int>();
            for(int i = 0; i < numberOfHeroes; i++)
            {
                string input = Console.ReadLine();
                string[]inputArg = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string hero = inputArg[0];
                int hp = int.Parse(inputArg[1]);
                int mp = int.Parse(inputArg[2]);
                if(!heroesAndHp.ContainsKey(hero))
                {
                    heroesAndHp.Add(hero, hp);
                    HeroesAndMana.Add(hero, mp);
                }
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] cmdArg = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                if(cmdType == "CastSpell")
                {
                    string hero = cmdArg[1];
                    int mp = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];
                    if (HeroesAndMana[hero] >= mp)
                    {
                        HeroesAndMana[hero] -= mp;
                        Console.WriteLine($"{hero} has successfully cast {spellName} and now has {HeroesAndMana[hero]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                    }
                }
                else if(cmdType == "TakeDamage")
                {
                    string hero = cmdArg[1];
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];
                    heroesAndHp[hero] -= damage;
                    if (heroesAndHp[hero] > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroesAndHp[hero]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                        heroesAndHp.Remove(hero);
                        HeroesAndMana.Remove(hero);
                    }
                }
                else if(cmdType == "Recharge")
                {
                    string hero = cmdArg[1];
                    int rechargeMana = int.Parse(cmdArg[2]);
                    int maxMana = 200;
                    int neededMana = maxMana - HeroesAndMana[hero];
                    HeroesAndMana[hero] += rechargeMana;
                    if (HeroesAndMana[hero] > maxMana)
                    {
                        HeroesAndMana[hero] = maxMana;
                        Console.WriteLine($"{hero} recharged for {neededMana} MP!");                        
                    }
                    else
                    {
                        Console.WriteLine($"{hero} recharged for {rechargeMana} MP!");
                    }
                }
                else if(cmdType == "Heal")
                {
                    string hero = cmdArg[1];
                    int rechargeHp = int.Parse(cmdArg[2]);
                    int maxHp = 100;
                    int neededHp = maxHp - heroesAndHp[hero];
                    heroesAndHp[hero] += rechargeHp;
                    if (heroesAndHp[hero] > maxHp)
                    {
                        heroesAndHp[hero] = maxHp;
                        Console.WriteLine($"{hero} healed for {neededHp} HP!");                      
                    }
                    else
                    {
                        Console.WriteLine($"{hero} healed for {rechargeHp} HP!");
                    }
                }
                command = Console.ReadLine();
            }
            foreach(string name in heroesAndHp.Keys)
            {
                Console.WriteLine(name);
                Console.WriteLine($"  HP: {heroesAndHp[name]}");
                Console.WriteLine($"  MP: {HeroesAndMana[name]}");
            }
        }
    }
}
