namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    class ExpressSoftware : Software
    {
        public override int MemoryConsumption
        {
            get => base.MemoryConsumption;
            set => base.MemoryConsumption = value * 2;
        }

        public ExpressSoftware(string name, int capacityConsumption, int memoryConsumption) 
            : base(name, capacityConsumption, memoryConsumption)
        {
        }
    }
}
