using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries.Lab
{
    public partial class SetsAndDictionariesLab
    {
        public static class _02SoftUniParty
        {
            public static void Solution()
            {
                var reservations = new SortedSet<string>();

                while (true)
                {
                    var reservation = Console.ReadLine();

                    if (reservation.ToLower() == "end")
                        break;

                    if (reservation.ToLower() == "party")
                    {
                        while (true)
                        {
                            reservation = Console.ReadLine();

                            if (reservation.ToLower() == "end")
                                break;

                            reservations.Remove(reservation);
                        }

                        Console.WriteLine(reservations.Count);
                        foreach (var r in reservations)
                        {
                            Console.WriteLine(r);
                        }

                        break;
                    }
                    reservations.Add(reservation);
                }
            }
        }
    }
}
