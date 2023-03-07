﻿using MilitaryElite.Models.Enum;
using MilitaryElite.Models.Interfaces;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName {get; private set;}

        public State State { get; private set; }

        public void CompleteMission()
        {
            State = State.Finished;
        }
        public override string ToString()
        {
            return $"  Code Name: {CodeName} State: {State}";
        }
    }
}
