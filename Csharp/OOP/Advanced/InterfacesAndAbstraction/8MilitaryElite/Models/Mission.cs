using System;
using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Enums;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    class Mission : IAuxiliary
    {
        private string _codeName;
        private MissionState _missionState;

        public string CodeName { get => _codeName; private set => _codeName = value; }
        public MissionState MissionState { get => _missionState; private set => _missionState = value; }

        public void CompleteMission()
        {
            this.MissionState = MissionState.Finished;
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"Code Name: {this.CodeName} State: {this.MissionState}");
            return sb.ToString();
        }

        public Mission(string codeName, string missionState)
        {
            this.CodeName = codeName;
            if (!Enum.TryParse(missionState, out _missionState))
                throw new ArgumentException("wrong mission state");
        }
    }

}
