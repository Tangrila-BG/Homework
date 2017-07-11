using Csharp.OOP.Basics.ExamPrep.SystemSplit.Components;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Factories
{
    class HardwareFactory : IFactory<Hardware>
    {
        public Hardware GetInstance(string[] parameters)
        {
            Hardware hardware;

            var type = parameters[0];
            var name = parameters[1];
            var maximumCapacity = int.Parse(parameters[2]);
            var maximumMemory = int.Parse(parameters[3]);

            switch (type)
            {
                case "heavy":
                    hardware = new HeavyHardware(name, maximumCapacity, maximumMemory);
                    break;

                default:
                    hardware = new PowerHardware(name, maximumCapacity, maximumMemory);
                    break;
            }

            return hardware;
        }
    }
}
