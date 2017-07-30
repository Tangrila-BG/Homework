using System;
using System.Linq;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._09TrafficLights
{
    class _09TrafficLights
    {
        public static void Solution()
        {
            var trafficLights = Console.ReadLine().Trim().Split()
                .Select(x => new TrafficLight(x))
                .ToList();

            var n = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < n; i++)
            {
                trafficLights.ForEach(t => t.ToggleSignal());
                Console.WriteLine(string.Join(" ", trafficLights));
            }

        }
    }
}
