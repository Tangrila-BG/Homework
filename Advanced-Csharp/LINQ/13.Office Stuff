using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.OfficeStuff
{
    class Program
    {
        static void Main(string[] args)
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
                })
                ;
            SortedDictionary<string, Dictionary<string, int>> office = new SortedDictionary<string, Dictionary<string, int>>();

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
                Console.Write($"{outerKvp.Key}: ");
                var index = 0;
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
