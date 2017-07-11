using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    class Dump
    {
        private ICollection<Hardware> _hardware;

        public IReadOnlyCollection<Hardware> Hardware => _hardware as IReadOnlyCollection<Hardware>;


        public void Collect(Hardware hardware)
        {
            this._hardware.Add(hardware);
        }

        public void Destroy(Hardware hardware)
        {
            this._hardware.Remove(hardware);
        }

        public Hardware Restore(string hardwareName)
        {
            var hardware =  this._hardware
                .Fetch(x => x.Name.Equals(hardwareName, StringComparison.OrdinalIgnoreCase));

            this.Destroy(hardware);

            return hardware;
        }

        public void Analyze()
        {
            var hardwareTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Hardware)));
            var softwareTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Software)));

            var sb = new StringBuilder();

            sb.AppendLine("Dump Analysis");

            foreach (var hardwareType in hardwareTypes)
            {
                sb.Append($"{hardwareType.Name.Replace("Hardware", " Hardware")} Components: ")
                    .AppendLine($"{this._hardware.Count(x => x.GetType() == hardwareType)}");
            }

            foreach (var softwareType in softwareTypes)
            {
                sb.Append($"{softwareType.Name.Replace("Software", " Software")} Components: ")
                    .AppendLine(
                        $"{this._hardware.SelectMany(x => x.Software).Count(x => x.GetType() == softwareType)}");
            }
            
            sb.AppendLine($"Total Dumped Memory: {this._hardware.Sum(x => x.UsedMemory)}")
                .AppendLine($"Total Dumped Capacity: {this._hardware.Sum(x => x.UsedCapacity)}");

            Console.WriteLine(sb.ToString());
        }

        public Dump()
        {
            this._hardware = new HashSet<Hardware>();
        }
    }
}
