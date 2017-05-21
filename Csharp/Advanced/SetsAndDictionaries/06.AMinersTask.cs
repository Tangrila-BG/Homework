using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _06AMinersTask
        {
            static void Solution()
            {
                int t = 0;
                var min = "-1";

                Dictionary<string, int> minerals = new Dictionary<string, int>();
                while (true)
                {
                    var input = Console.ReadLine();

                    if (input.ToLower() == "stop")
                        break;

                    if (t % 2 == 0 && !minerals.ContainsKey(input))
                    {
                        min = input;
                        minerals.Add(input, 0);
                    }
                    else if (t % 2 == 1 && min != "-1")
                        minerals[min] += int.Parse(input);

                    t++;
                    t %= 2;
                }

                foreach (var mineral in minerals)
                    Console.WriteLine($"{mineral.Key} -> {mineral.Value}");
            }
        }
    }
}
