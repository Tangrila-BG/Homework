using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._14.CatLady
{
    public static partial class _14CatLady
    {
        public static void Solution()
        {
            var cats = new HashSet<Cat>();
            Cat cat;

            while (true)
            {
                var input = Console.ReadLine().Trim();

                if (input.ToLower() == "end")
                    break;

                var info = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var breed = info[0];
                var name = info[1];


                switch (breed)
                {
                    case "Cymric":
                        cat = new Cymric(name, double.Parse(info[2]));
                        break;
                    case "Siamese":
                        cat = new Siamese(name, int.Parse(info[2]));
                        break;
                    default:
                        cat = new StreetExtraordinaire(name, int.Parse(info[2]));
                        break;
                }

                cats.Add(cat);
            }

            var target = Console.ReadLine().Trim();
            cat = cats.First(x => x.Name.Equals(target));

            Console.WriteLine(cat);
        }
    }

}
