using System.Collections.Generic;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._8MilitaryElite.Interfaces
{
    interface ILuetenantGeneral
    {
        HashSet<ISoldier> Privates { get; }
    }

}
