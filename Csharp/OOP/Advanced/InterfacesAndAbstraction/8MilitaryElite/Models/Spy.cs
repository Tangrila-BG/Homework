using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        private string _codeNumber;

        public string CodeNumber { get => this._codeNumber; private set => this._codeNumber = value; }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.AppendLine()
                .Append($"Code Number: {this.CodeNumber.TrimStart(new char[] { '0' })}");

            return sb.ToString();
        }

        public Spy(string id, string firstName, string lastName, string codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }
    }

}
