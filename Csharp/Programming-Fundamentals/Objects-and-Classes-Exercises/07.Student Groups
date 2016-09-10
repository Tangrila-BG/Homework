
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = DistributeStudentsIntoGroups(ReadTownAndStudents());
            Console.WriteLine("Created {0} groups in {1} towns:",
                output.Count, output.Select(x => x.Town).Distinct().Count());
            foreach (var @group in output.OrderBy(x => x.Town.Name))
            {
                Console.WriteLine($"{group.Town.Name} => {string.Join(", ", group.Students.Select(x => x.Email))}");
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();
            foreach (var town in towns)
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(s => s.RegistrationDate)
                    .ThenBy(s => s.Name).ThenBy(s => s.Email);
                while (students.Any())
                {
                    var group = new Group
                    {
                        Town = town,
                        Students = students.Take(town.Capacity).ToList(),
                    };
                    students = students.Skip(town.Capacity);
                    groups.Add(group);
                }
            }
            return groups;
        }

        static List<Town> ReadTownAndStudents()
        {
            var towns = new List<Town>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "End")
                    break;
                if (inputLine.Contains("=>"))
                {
                    var town = new Town
                    {
                        Name = inputLine.Substring(0, inputLine.IndexOf("=")).Trim(),
                        Capacity = int.Parse(string.Join("", inputLine.Where(char.IsDigit))),
                        Students = new List<Student>()
                    };
                    towns.Add(town);
                }
                else
                {
                    var temp = inputLine.Split('|').Select(x => x.Trim()).ToArray();
                    var student = new Student
                    {
                        Name = temp[0],
                        Email = temp[1],
                        RegistrationDate = DateTime.ParseExact(temp[2], "d-MMM-yyyy", CultureInfo.InvariantCulture)
                    };
                    towns.Last().Students.Add(student);
                }
            }
            return towns;
        }

        class Town
        {
            public string Name { get; set; }
            public int Capacity { get; set; }
            public List<Student> Students { get; set; }

            public double Groups()
            {
                return (double) Math.Max(Capacity, Students.Count) / Math.Min(Capacity, Students.Count);
            }
        }

        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }

        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
    }
}
