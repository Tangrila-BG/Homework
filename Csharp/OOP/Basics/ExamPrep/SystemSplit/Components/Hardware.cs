using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Csharp.OOP.Basics.ExamPrep.SystemSplit.Components
{
    abstract class Hardware : IComponent
    {
        private ICollection<Software> _software;

        public string Name { get; set; }
        public int UsedMemory { get; set; }
        public int UsedCapacity { get; set; }
        public virtual int MaximumCapacity { get; set; }
        public virtual int MaximumMemory { get; set; }
        public IReadOnlyCollection<Software> Software => _software as IReadOnlyCollection<Software>;

        public void AddSoftware(Software software)
        {
            if (software.CapacityConsumption > this.MaximumCapacity - this.UsedCapacity)
                throw new ArgumentException("Insufficient hardware capacity");

            if (software.MemoryConsumption > this.MaximumMemory - this.UsedMemory)
                throw new ArgumentException("Insufficient hardware memory");

            this.UsedCapacity += software.CapacityConsumption;
            this.UsedMemory += software.MemoryConsumption;

            this._software.Add(software);
        }

        public void RemoveSoftware(Software software)
        {
            this.UsedCapacity -= software.CapacityConsumption;
            this.UsedMemory -= software.MemoryConsumption;

            this._software.Remove(software);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var softwareTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => x.IsSubclassOf(typeof(Software)));

            sb.AppendLine($"Hardware Component - {this.Name}");
            
            foreach (var softwareType in softwareTypes)
            {
                sb.Append($"{softwareType.Name.Replace("Software", " Software")} Components - ")
                    .AppendLine($"{this._software.Count(x => x.GetType() == softwareType)}");
            }

            sb.AppendLine($"Memory Usage: {this.UsedMemory} / {this.MaximumMemory}")
                .AppendLine($"Capacity Usage: {this.UsedCapacity} / {this.MaximumCapacity}")
                .AppendLine($"Type: {this.GetType().Name.Replace("Hardware", "")}")
                .Append($"Software Components: " +
                        $"{(this._software.Any() ? string.Join(", ", this._software.Select(x => x.Name)) : "None")}");

            return sb.ToString();
        }

        protected Hardware(string name, int maximumCapacity, int maximumMemory)
        {
            this.Name = name;
            this.MaximumCapacity = maximumCapacity;
            this.MaximumMemory = maximumMemory;
            this._software = new HashSet<Software>();
        }
    }
}
