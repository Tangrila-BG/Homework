namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    abstract class Software : IComponent
    {
        public string Name { get; set; }
        public virtual int CapacityConsumption { get; set; }
        public virtual int MemoryConsumption { get; set; }


        protected Software(string name, int capacityConsumption, int memoryConsumption)
        {
            Name = name;
            CapacityConsumption = capacityConsumption;
            MemoryConsumption = memoryConsumption;
        }
    }
}
