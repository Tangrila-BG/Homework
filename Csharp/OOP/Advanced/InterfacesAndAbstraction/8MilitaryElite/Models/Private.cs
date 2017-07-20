using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    class Private : Soldier, IPrivate
    {
        private double _salary;

        public double Salary { get => this._salary; private set => this._salary = value; }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString())
                .Append($" Salary: {this.Salary:F2}");

            return sb.ToString();
        }

        public Private(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }
    }

}
