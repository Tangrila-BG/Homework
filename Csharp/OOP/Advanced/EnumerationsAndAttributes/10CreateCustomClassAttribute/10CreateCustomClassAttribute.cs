﻿using System;
using System.Linq;

namespace Csharp.OOP.Advanced.EnumerationsAndAttributes._10CreateCustomClassAttribute
{
    class _10CreateCustomClassAttribute
    {
        public static void Solution()
        {
            var attributes = typeof(Weapon)
                    .GetCustomAttributes(typeof(CustomClassAttribute), false)
                    .OfType<CustomClassAttribute>()
                    .SingleOrDefault();

            while (true)
            {

                var attrProp = Console.ReadLine().Trim();

                if (attrProp == "END")
                    break;

                var output = string.Empty;

                switch (attrProp)
                {
                    case "Author":
                        output = $"Author: {attributes.Author}";
                        break;
                    case "Revision":
                        output = $"Revision: {attributes.Revision}";
                        break;
                    case "Description":
                        output = $"Class description: {attributes.Description}";
                        break;
                    case "Reviewers":
                        output = $"Reviewers: {string.Join(", ", attributes.Reviewers)}";
                        break;
                }

                Console.WriteLine(output);
            }
        }
    }

    [CustomClass
        (Author = "Pesho",
        Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.",
        Revision = 3,
        Reviewers = new string[] { "Pesho", "Svetlio" })]
    class Weapon { }

    class CustomClassAttribute : Attribute
    {
        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public string[] Reviewers { get; set; }
    }
}
