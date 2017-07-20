using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    class Repair : IAuxiliary
    {
        private string _partName;
        private int _hoursWorked;

        public string PartName { get => _partName; private set => _partName = value; }
        public int HoursWorked { get => _hoursWorked; private set => _hoursWorked = value; }

        public override string ToString()
        {
            var sb = new StringBuilder($"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");
            return sb.ToString();
        }

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }
    }

}
