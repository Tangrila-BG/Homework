using System;
using Csharp.OOP.Basics.ExamPrep.SystemSplit.Components;
using Csharp.OOP.Basics.ExamPrep.SystemSplit.Factories;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    class Executor
    {
        private static Extractor _extractor = new Extractor();

        public static void Execute(string input, Csharp.OOP.Basics.ExamPrep.SystemSplit.System system)
        {
            var hardwareFactory = new HardwareFactory();
            var softwareFactory = new SoftwareFactory();
            Hardware hardware = null;
            Software software = null;

            if (input.Contains("Hardware"))
            {
                hardware = hardwareFactory.GetInstance(_extractor.ExtractHardwareParams(input));
            }
            else if (input.Contains("Release"))
            {
                var softwareAndHardwareNames = _extractor.ExtractParams(input);

                hardware = system.FindHardware(softwareAndHardwareNames[0]);
                software = system.FindSoftware(softwareAndHardwareNames[1]);
            }
            else if (input.Contains("Software"))
            {
                var softwareParameters = _extractor.ExtractSoftwareParams(input);

                hardware = system.FindHardware(softwareParameters[1]);

                software = softwareFactory.GetInstance(softwareParameters);
            }
            else if (input.StartsWith("Dump") || input.StartsWith("Destroy") || input.StartsWith("Restore"))
            {
                var hardwareName = _extractor.ExtractParams(input)[0];

                if (input.StartsWith("Destroy"))
                {
                    hardware = system.Dumpster.Hardware
                        .Fetch(x => x.Name.Equals(hardwareName, StringComparison.OrdinalIgnoreCase));

                    system.Destroy(hardware);
                }
                else if (input.StartsWith("Restore"))
                {
                    hardware = system.Dumpster.Hardware
                        .Fetch(x => x.Name.Equals(hardwareName, StringComparison.OrdinalIgnoreCase));

                    system.Restore(hardware);
                }
                else
                {
                    hardware = system.FindHardware(hardwareName);

                    system.Dump(hardware);
                }
            }

            if (input.Contains("Register"))
                system.RegisterComponent((IComponent)software ?? hardware, hardware);
            else
                system.RemoveSoftware(hardware, software);
        }
    }
}
