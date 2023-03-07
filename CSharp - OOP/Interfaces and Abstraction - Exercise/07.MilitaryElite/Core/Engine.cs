using MilitaryElite.Core.Interfaces;
using MilitaryElite.Models;
using MilitaryElite.Models.Enum;
using MilitaryElite.Models.Interfaces;
using System.Diagnostics;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private Dictionary<int, ISoldier> soldiers;
        public Engine()
        {
            soldiers = new Dictionary<int, ISoldier>();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                try
                {
                    string[] inputArg = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    Console.WriteLine(ProcessInput(inputArg));
                    
                }
                catch (ArgumentException ex)
                {

                }
                input = Console.ReadLine();
            }
        }

        private string ProcessInput(string[] inputArg)
        {
            string soldierType = inputArg[0];
            int id = int.Parse(inputArg[1]);
            string firstName = inputArg[2];
            string lastName = inputArg[3];
            ISoldier soldier = null;
            switch (soldierType)
            {
                case "Private":
                    soldier = GetPrivate(id, firstName, lastName, decimal.Parse(inputArg[4]));
                    break;
                case "LieutenantGeneral":
                    soldier = GetLieutenantGeneral(id, firstName, lastName, inputArg);
                    break;
                case "Engineer":
                    soldier = GetEngineer(id, firstName, lastName, inputArg);
                    break;
                case "Commando":
                    soldier = GetCommando(id, firstName, lastName, inputArg);
                    break;
                case "Spy":
                    soldier = GetSpy(id, firstName, lastName, int.Parse(inputArg[4]));
                    break;
            }
            soldiers.Add(id, soldier);

            return soldier.ToString();
        }

        private ISoldier GetSpy(int id,string firstName, string lastName, int codeNumber )
        {
            return new Spy(id, firstName, lastName, codeNumber);
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, string[] inputArg)
        {
            decimal salary = decimal.Parse(inputArg[4]);
            bool isValidCorps = Enum.TryParse(inputArg[5], out Corps corps);
            if (!isValidCorps)
            {
                throw new ArgumentException();
            }
            List<IMission> missions = new List<IMission>();

            for (int i = 6; i < inputArg.Length; i += 2)
            {
                string missionName = inputArg[i];
                string missionState = inputArg[i + 1];

                bool isValidMissionState = Enum.TryParse(missionState, out State state);
                if (!isValidMissionState)
                {
                    continue;
                }
                IMission mission = new Mission(missionName, state);
                missions.Add(mission);
            }
                return new Commando(id, firstName, lastName, salary, corps, missions);
            
        }
            private ISoldier GetEngineer(int id, string firstName, string lastName, string[] inputArg)
            {
                decimal salary = decimal.Parse(inputArg[4]);
                bool isValidCorps = Enum.TryParse(inputArg[5], out Corps corps);
                if (!isValidCorps)
                {
                    throw new ArgumentException();
                }
                List<IRepair> repairs = new();
                for (int i = 6; i < inputArg.Length; i += 2)
                {
                    string partName = inputArg[i];
                    int hoursWorked = int.Parse(inputArg[i + 1]);
                    IRepair repair = new Repair(partName, hoursWorked);
                    repairs.Add(repair);
                }

                return new Engineer(id, firstName, lastName, salary, corps, repairs);
            }

            private ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, string[] inputArg)
            {
                decimal salary = decimal.Parse(inputArg[4]);
                List<IPrivate> privates = new();
                for (int i = 5; i < inputArg.Length; i++)
                {
                    int soldierId = int.Parse(inputArg[i]);
                    IPrivate soldier = (IPrivate)soldiers[soldierId];
                    privates.Add(soldier);
                }
                return new LieutenantGeneral(id, firstName, lastName, salary, privates);
            }

            private ISoldier GetPrivate(int id, string firstName, string lastName, decimal salary)
            {
                return new Private(id, firstName, lastName, salary);
            }
        }
    } 
