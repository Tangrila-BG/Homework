using System;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    class HeavyHardware : Hardware
    {
        public override int MaximumCapacity
        {
            get => base.MaximumCapacity;
            set => base.MaximumCapacity = value * 2;
        }

        public override int MaximumMemory
        {
            get => base.MaximumMemory;
            set => base.MaximumMemory = (int) Math.Ceiling(value * 0.75);
        }

        public HeavyHardware(string name, int maximumCapacity, int maximumMemory) 
            : base(name, maximumCapacity, maximumMemory)
        {
        }
    }
}
