using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();
            while (t-- > 0)
            {
                Sale sale = ReadSale();
                if (!salesByTown.ContainsKey(sale.Town))
                    salesByTown.Add(sale.Town, sale.Revenue());
                else
                    salesByTown[sale.Town] += sale.Revenue();
            }

            foreach (var kvp in salesByTown)
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");

        }

        public static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            var sale = new Sale
            {
                Town = input[0],
                Product = input[1],
                Price = decimal.Parse(input[2]),
                Quantity = decimal.Parse(input[3])
            };

            return sale;
        }

        internal class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public decimal Revenue() {return Price * Quantity;}
        }
    }
}
