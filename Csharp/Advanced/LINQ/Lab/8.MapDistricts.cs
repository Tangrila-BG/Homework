using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.LINQ.Lab
{
    public partial class LinqLab
    {
        public static class _8MapDistricts
        {
            public static void Solution()
            {
                var towns = Console.ReadLine()
                    .Trim()
                    .Split()
                    .Select(x =>
                    {
                        var e = x.Split(':');
                        return new { City = e[0], Population = long.Parse(e[1]) };
                    })
                    .GroupBy(x => x.City)
                    .Select(x => new { City = x.Key, Districts = x.Select(y => y.Population) });

                var minimum = long.Parse(Console.ReadLine().Trim());

                towns = towns.Where(x => x.Districts.Sum() >= minimum);

                foreach (var town in towns.OrderByDescending(x => x.Districts.Sum()))
                {
                    Console.WriteLine("{0}: {1}",
                        town.City,
                        string.Join(" ", town.Districts
                            .OrderByDescending(x => x)
                            .Take(5)));
                }
            }
        }
    }
}
