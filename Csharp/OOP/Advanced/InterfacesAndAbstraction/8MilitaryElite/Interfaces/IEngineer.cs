using System.Collections.Generic;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces
{
    interface IEngineer
    {
        HashSet<IAuxiliary> Repairs { get; }
    }

}
