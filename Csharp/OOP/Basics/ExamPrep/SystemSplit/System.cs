using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Csharp.OOP.Basics.ExamPrep.SystemSplit.Components;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    class System
    {
        private readonly ICollection<Hardware> _hardware;
        private readonly ICollection<Software> _software;
        private readonly Dump _dump;

        public Dump Dumpster => _dump;

        private void RegisterHardware(Hardware hardware)
        {
            this._hardware.Add(hardware);
        }

        private void RegisterSoftware(Software software, Hardware hardware)
        {
            hardware.AddSoftware(software);

            this._software.Add(software);
        }

        public void RegisterComponent(IComponent component, Hardware hardware = null)
        {
            if (component is Hardware)
                this.RegisterHardware((Hardware) component);
            else if (component is Software)
                this.RegisterSoftware((Software) component, hardware);
        }

        public void RemoveSoftware(Hardware hardware, Software software)
        {
            hardware.RemoveSoftware(software);

            this._software.Remove(software);
        }

        public void Dump(Hardware hardware)
        {
            this._hardware.Remove(hardware);
            var software = hardware.Software;

            foreach (var soft in software)
            {
                this._software.Remove(soft);
            }

            this._dump.Collect(hardware);
        }

        public void Destroy(Hardware hardware)
        {
            this._dump.Destroy(hardware);
        }

        public void Restore(Hardware hardware)
        {
            this._hardware.Add(hardware);
            var software = hardware.Software;

            foreach (var soft in software)
            {
                this._software.Add(soft);
            }

            this._dump.Destroy(hardware);
        }

        public Hardware FindHardware(string hardwareName)
        {
            return this._hardware
                .Fetch(x => x.Name.Equals(hardwareName, StringComparison.OrdinalIgnoreCase));
        }

        public Software FindSoftware(string softwareName)
        {
            return _software
                .Fetch(x => x.Name.Equals(softwareName, StringComparison.OrdinalIgnoreCase));
        }

        public void Analyze()
        {
            var sb = new StringBuilder();

            sb.AppendLine("System Analysis")
                .AppendLine($"Hardware Components: {this._hardware.Count}")
                .AppendLine($"Software Components: {this._software.Count}")
                .Append($"Total Operational Memory: {this._hardware.Sum(x => x.UsedMemory)} / ")
                .AppendLine($"{this._hardware.Sum(x => x.MaximumMemory)}")
                .Append($"Total Capacity Taken: {this._hardware.Sum(x => x.UsedCapacity)} / ")
                .Append($"{this._hardware.Sum(x => x.MaximumCapacity)}");

            Console.WriteLine(sb.ToString());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var hardware in this._hardware)
            {
                sb.AppendLine(hardware.ToString());
            }

            return sb.ToString();
        }

        public System()
        {
            this._hardware = new HashSet<Hardware>();
            this._software = new HashSet<Software>();
            this._dump = new Dump();
        }
    }
}
