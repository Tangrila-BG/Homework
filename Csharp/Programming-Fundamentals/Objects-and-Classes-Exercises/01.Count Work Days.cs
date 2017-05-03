using System;
using System.Collections.Generic;
using System.Globalization;

namespace _01.CountWorkDays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holidays = new List<DateTime>
            {
                // year, month, day
                new DateTime(1999, 1, 1), new DateTime(1999, 3, 3),
                new DateTime(1999, 5, 1), new DateTime(1999, 5, 6),
                new DateTime(1999, 5, 24), new DateTime(1999, 9, 6),
                new DateTime(1999, 9, 22), new DateTime(1999, 11, 1),
                new DateTime(1999, 12, 24), new DateTime(1999, 12, 25),
                new DateTime(1999, 12, 26)
            };

            
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workDays = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // adjust holidays to current year
                if (holidays[0].Year != date.Year)
                {
                    var addYears = Math.Abs(holidays[0].Year - date.Year);
                    for (int i = 0; i < holidays.Count; i++)
                        holidays[i] = holidays[i].AddYears(addYears);
                }

                if (holidays.Contains(date) || date.DayOfWeek == DayOfWeek.Sunday ||
                    date.DayOfWeek == DayOfWeek.Saturday)
                    continue;

                workDays++;
            }

            Console.WriteLine(workDays);
        }
    }
}
