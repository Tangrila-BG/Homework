using System;

namespace Csharp.OOP.Basics.Polymorphism._2.VehiclesExtension
{
    public static partial class _2VehiclesExtension
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
