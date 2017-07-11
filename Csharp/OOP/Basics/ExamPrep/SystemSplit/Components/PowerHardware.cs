using System;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    class PowerHardware : Hardware
    {
        public override int MaximumCapacity
        {
            get => base.MaximumCapacity;
            set => base.MaximumCapacity = (int) Math.Ceiling(value * 0.25);
        }

        public override int MaximumMemory
        {
            get => base.MaximumMemory;
            set => base.MaximumMemory = (int) Math.Ceiling(value * 1.75);
        }

        public PowerHardware(string name, int maximumCapacity, int maximumMemory) 
            : base(name, maximumCapacity, maximumMemory)
        {
        }
    }
}
