using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming.Lab
{
    public partial class FunctionalProgrammingLab
    {
        public static class _5FilterByAge
        {
            public static void Solution()
            {

            }

            public static void Solution2()
            {
                var dict = new Dictionary<string, int>();
                var n = int.Parse(Console.ReadLine());
                var cmd = new string[2];

                Enumerable.Range(0, n + 3)
                    .ToList()
                    .ForEach(turn =>
                    {
                        if (turn < n)
                        {
                            var student = Console.ReadLine()
                                .Trim()
                                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                            dict.Add(student[0], int.Parse(student[1]));
                        }
                        else
                        {
                            if (turn < n + 2)
                                cmd[turn - n] = Console.ReadLine();
                            else
                            {
                                var show = Console.ReadLine().Trim().Split();

                                dict = cmd[0] == "older"
                                    ? dict
                                        .Where(x => x.Value >= int.Parse(cmd[1]))
                                        .ToDictionary(pair => pair.Key, p => p.Value)
                                    : dict
                                        .Where(x => x.Value < int.Parse(cmd[1]))
                                        .ToDictionary(pair => pair.Key, p => p.Value);

                                Enumerable.Range(0, dict.Count).ToList()
                                .ForEach(i =>
                                    {
                                        Console.WriteLine(show.Length > 1
                                            ? $"{dict.Keys.ToArray()[i]} - {dict.Values.ToArray()[i]}"
                                            : (show[0] == "name"
                                                ? $"{dict.Keys.ToArray()[i]}"
                                                : $"{dict.Values.ToArray()[i]}"));
                                    });
                            }
                        }
                    });
            }
        }
    }
}
