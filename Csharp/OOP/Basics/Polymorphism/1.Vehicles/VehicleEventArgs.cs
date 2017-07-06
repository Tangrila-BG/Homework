using System;

namespace Csharp.OOP.Basics.Polymorphism._1.Vehicles
{
    public static partial class _1Vehicles
    {
        class VehicleEventArgs : EventArgs
        {
            public double Distance { get; }
            public bool NeedRefuel { get; }

            public VehicleEventArgs(double distance, bool needRefuel)
            {
                this.Distance = distance;
                this.NeedRefuel = needRefuel;
            }
        }
    }
}
