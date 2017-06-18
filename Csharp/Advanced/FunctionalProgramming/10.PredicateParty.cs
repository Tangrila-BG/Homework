using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _10PredicateParty
        {
            public static void Solution()
            {
                Func<string, string, bool> startsWith = (x, s) => x.StartsWith(s);
                Func<string, string, bool> endsWith = (x, s) => x.EndsWith(s);
                Func<string, int, bool> length = (x, s) => x.Length == s;

                var guests = Console.ReadLine()
                    .Trim()
                    .Split()
                    .ToList();

                while (true)
                {
                    var operation = Console.ReadLine()
                        .Trim()
                        .Split();

                    if (operation[0] == "Party!") break;

                    switch (operation[0])
                    {
                        case "Remove":
                            if (operation[1] == "StartsWith")
                                guests.RemoveAll(x => startsWith(x, operation[2]));
                            else if (operation[1] == "EndsWith")
                                guests.RemoveAll(x => endsWith(x, operation[2]));
                            else
                                guests.RemoveAll(x => length(x, int.Parse(operation[2])));
                            break;

                        case "Double":
                            if (operation[1] == "StartsWith")
                                guests = guests.Concat(guests.Where(x => startsWith(x, operation[2]))).ToList();
                            else if (operation[1] == "EndsWith")
                                guests = guests.Concat(guests.Where(x => endsWith(x, operation[2]))).ToList();
                            else
                                guests = guests.Concat(guests.Where(x => length(x, int.Parse(operation[2])))).ToList();
                            break;
                    }
                }
                if (guests.Count > 0)
                    Console.WriteLine(string.Join(", ", guests) + " are going to the party!");
                else
                    Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
