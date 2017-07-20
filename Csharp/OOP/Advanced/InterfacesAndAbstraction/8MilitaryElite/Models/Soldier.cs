using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    abstract class Soldier : ISoldier
    {
        private string _id;
        private string _firstName;
        private string _lastName;

        public string Id { get => _id; private set => this._id = value; }
        public string FirstName { get => this._firstName; private set => this._firstName = value; }
        public string LastName { get => this._lastName; private set => this._lastName = value; }

        public override string ToString()
        {
            var sb = new StringBuilder($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");

            return sb.ToString();
        }

        protected Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }

}
