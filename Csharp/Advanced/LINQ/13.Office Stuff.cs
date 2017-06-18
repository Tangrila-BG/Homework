using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Csharp.Advanced.LINQ
{
    public partial class Linq
    {
        private static SortedDictionary<string, Dictionary<string, int>> office;

        public static void _13OfficeStuff(string[] args)
        {
            var pattern = "^\\|(?<company>[A-Za-z]+) - (?<amount>\\d+) - (?<product>[A-Za-z]+)\\|$";

            office = new SortedDictionary<string, Dictionary<string, int>>();

            var n = int.Parse(Console.ReadLine().Trim());

            while (n-- > 0)
                AddOrUpdateCompany(Regex.Match(Console.ReadLine().Trim(), pattern));

            PrintCompanies();
        }

        private static void PrintCompanies()
        {
            foreach (var company in office)
            {
                Console.Write(company.Key + ": ");

                var products = company.Value
                    .GroupBy(x => x.Key)
                    .Select(x => new
                    {
                        Product = x.Key,
                        Amount = x.Select(y => y.Value).Sum()
                    })
                    .Select((a, b) => a.Product + "-" + a.Amount);

                Console.WriteLine(string.Join(", ", products));
            }
        }

        private static void AddOrUpdateCompany(Match match)
        {
            var company = match.Groups["company"].Value;
            var product = match.Groups["product"].Value;
            var amount = int.Parse(match.Groups["amount"].Value);

            if (!office.ContainsKey(company))
                office.Add(company, new Dictionary<string, int>());

            if (!office[company].ContainsKey(product))
                office[company].Add(product, 0);

            office[company][product] += amount;
        }

        private static void Solution2()
        {
            List<string> info = new List<string>();

            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
                info.Add(Console.ReadLine());

            var output = info
                    .Select(x => new
                    {
                        Company = x.Substring(1, x.IndexOf(" ")).Trim(),
                        Amount = int.Parse(string.Join("", x.Where(char.IsDigit))),
                        Product = string.Join("", x.Substring(x.LastIndexOf(" ")).Where(char.IsLetter))
                    });

            var office = new SortedDictionary<string, Dictionary<string, int>>();

            foreach (var test in output)
            {
                if (!office.ContainsKey(test.Company))
                    office.Add(test.Company, new Dictionary<string, int>
                    {
                        {test.Product, test.Amount}
                    });
                else if (!office[test.Company].ContainsKey(test.Product))
                    office[test.Company].Add(test.Product, test.Amount);
                else
                    office[test.Company][test.Product] += test.Amount;
            }

            foreach (var outerKvp in office)
            {
                var index = 0;

                Console.Write($"{outerKvp.Key}: ");

                foreach (var innerKvp in outerKvp.Value)
                {
                    Console.Write($"{innerKvp.Key}-{innerKvp.Value}");

                    if (index < outerKvp.Value.Count - 1)
                        Console.Write(", ");

                    index++;
                }

                Console.WriteLine();
            }
        }
    }
}
