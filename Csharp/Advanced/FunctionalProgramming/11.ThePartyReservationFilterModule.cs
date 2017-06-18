using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _11ThePartyReservationFilterModule
        {
            public static void Solution()
            {
                var filters = new Dictionary<string, Func<string, string, bool>>();
                Func<string, string, bool> startsWith = (x, s) => x.StartsWith(s);
                Func<string, string, bool> endsWith = (x, s) => x.EndsWith(s);
                Func<string, string, bool> length = (x, s) => x.Length == int.Parse(s);
                Func<string, string, bool> contains = (x, s) => x.Contains(s);

                filters.Add("Starts with", startsWith);
                filters.Add("Ends with", endsWith);
                filters.Add("Length", length);
                filters.Add("Contains", contains);

                var guests = Console.ReadLine()
                    .Trim()
                    .Split();


                var appliedFilters = new Dictionary<string, List<KeyValuePair<string, Func<string, string, bool>>>>();

                while (true)
                {
                    var args = Console.ReadLine()
                        .Trim()
                        .Split(';');

                    if (args[0].Equals("print", StringComparison.OrdinalIgnoreCase))
                        break;

                    switch (args[0].ToLower())
                    {
                        case "add filter":
                            if (appliedFilters.ContainsKey(args[1]))
                            {
                                if (!appliedFilters[args[1]].Exists(x => x.Key == args[2]))
                                {
                                    appliedFilters[args[1]]
                                        .Add(
                                            new KeyValuePair<string, Func<string, string, bool>>(args[2],
                                                filters[args[1]]));
                                }
                            }
                            else
                            {
                                appliedFilters.Add(args[1], new List<KeyValuePair<string, Func<string, string, bool>>>
                                {
                                    new KeyValuePair<string, Func<string, string, bool>>(args[2], filters[args[1]])
                                });
                            }
                            break;
                        case "remove filter":
                            if (!appliedFilters.ContainsKey(args[1]))
                                break;

                            try
                            {
                                var filter = appliedFilters[args[1]].Find(x => x.Key == args[2]);
                                appliedFilters[args[1]].Remove(filter);
                            }
                            catch (Exception)
                            {
                                // ignored
                            }
                            break;
                    }
                }

                guests = appliedFilters
                    .SelectMany(appliedFilter => appliedFilter.Value)
                    .Aggregate(guests, (current, filter) =>
                        current.Where(x => !filter.Value(x, filter.Key))
                        .ToArray());

                Console.WriteLine(string.Join(" ", guests));
            }
        }
    }
}
