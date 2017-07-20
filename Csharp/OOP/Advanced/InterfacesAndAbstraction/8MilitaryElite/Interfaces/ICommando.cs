using System.Collections.Generic;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces
{
    interface ICommando
    {
        HashSet<IAuxiliary> Missions { get; }
    }

}
