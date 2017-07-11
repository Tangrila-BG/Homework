using Csharp.OOP.Basics.ExamPrep.SystemSplit.Components;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Factories
{
    class SoftwareFactory : IFactory<Software>
    {
        public Software GetInstance(string[] parameters)
        {
            Software software;

            var type = parameters[0];
            var name = parameters[2];
            var capacityConsumption = int.Parse(parameters[3]);
            var memoryConsumption   = int.Parse(parameters[4]);

            switch (type)
            {
                case "express":
                    software = new ExpressSoftware(name, capacityConsumption, memoryConsumption);
                    break;

                default:
                    software = new LightSoftware(name, capacityConsumption, memoryConsumption);
                    break;
            }

            return software;
        }
    }
}
