﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _11LogsAggregator
        {
            static void Solution()
            {
                int t = int.Parse(Console.ReadLine());

                // SortedList {string USERNAME, Dictionary { string IP, int DURATION } }
                SortedList<string, SortedDictionary<string, int>> log =
                    new SortedList<string, SortedDictionary<string, int>>();

                while (t-- > 0)
                {
                    string[] input = Console.ReadLine().Split();

                    string ip = input[0];
                    string username = input[1];
                    int duration = int.Parse(input[2]);

                    if (!log.ContainsKey(username))
                        log.Add(username, new SortedDictionary<string, int> { { ip, duration } });

                    else if (!log[username].ContainsKey(ip))
                        log[username].Add(ip, duration);

                    else
                        log[username][ip] += duration;

                }

                foreach (var kvp in log)
                {
                    Console.WriteLine("{0}: {2} [{1}]",
                        kvp.Key,
                        string.Join(", ", kvp.Value.Select(x => x.Key)),
                        kvp.Value.Values.Sum());
                }
            }
        }
    }
}
