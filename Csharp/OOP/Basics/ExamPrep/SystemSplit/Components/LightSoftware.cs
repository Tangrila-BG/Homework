using System;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    class LightSoftware : Software
    {
        public override int MemoryConsumption
        {
            get => base.MemoryConsumption;
            set => base.MemoryConsumption = (int) Math.Ceiling(value * 0.5);
        }

        public override int CapacityConsumption
        {
            get => base.CapacityConsumption;
            set => base.CapacityConsumption = (int) Math.Ceiling(value * 1.5);
        }


        public LightSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, capacityConsumption, memoryConsumption)
        {
        }
    }
}
