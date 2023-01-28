using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets = new List<Pet>();        
        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }
        public int Capacity { get; set; }

        public void Add(Pet pet)
        {
            if(Capacity > pets.Count)
            {
                pets.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if(pets.Any(x => x.Name == name))
            {
                Pet currentPet = pets.Where(x => x.Name == name).First();
                pets.Remove(currentPet);
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if(pets.Any(x => x.Name == name && x.Owner == owner))
            {
                Pet currenPet = pets.Where(x => x.Name == name && x.Owner == owner).First();
                return currenPet;
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Age).First();
                                   
        }

        public int Count => pets.Count;

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach(Pet pet in pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString();
        }
    }
}
