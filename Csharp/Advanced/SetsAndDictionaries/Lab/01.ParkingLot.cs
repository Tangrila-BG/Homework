using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries.Lab
{
    public partial class SetsAndDictionariesLab
    {
        public static class _01ParkingLot
        {
            public static void Solution()
            {
                var set = new SortedSet<string>();
                var separator = " ,".ToCharArray();

                while (true)
                {
                    var input = Console.ReadLine()
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    if (input[0].ToLower() == "end")
                        break;

                    var direction = input[0].ToLower();
                    var license = input[1];
                    set.Add(license);

                    if (direction == "out")
                        set.Remove(license);
                }

                foreach (var s in set)
                {
                    Console.WriteLine(s);
                }

                if (set.Count == 0)
                    Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
