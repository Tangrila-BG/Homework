using System.Collections.Generic;
using System.Text;
using Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Models
{
    class LuetenantGeneral : Private, ILuetenantGeneral
    {
        private HashSet<ISoldier> _privates;

        public HashSet<ISoldier> Privates => _privates;

        public void AddPrivate(ISoldier @private)
        {
            this._privates.Add(@private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder(base.ToString());

            sb.AppendLine()
                .AppendLine($"Privates:");
            foreach (var @private in this.Privates)
            {
                sb.AppendLine(new string(' ', Helper.Indentation) + @private);
            }

            return sb.ToString().Trim();
        }

        public LuetenantGeneral(string id, string firstName, string lastName, double salary)
            : base(id, firstName, lastName, salary)
        {
            this._privates = new HashSet<ISoldier>();
        }
    }

}
