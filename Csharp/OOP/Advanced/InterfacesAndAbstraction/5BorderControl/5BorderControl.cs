using System;
using System.Collections.Generic;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._5BorderControl
{
    class _5BorderControl
    {
        public static void Solution()
        {
            var inhabitants = new List<IIdentifiable>();

            while (true)
            {
                var input = Console.ReadLine().Trim().Split();

                if (input[0].Equals("End", StringComparison.OrdinalIgnoreCase))
                    break;

                if (input.Length == 3)
                    inhabitants.Add(new Citizen(input[0], int.Parse(input[1]), input[2]));
                else
                    inhabitants.Add(new Robot(input[0], input[1]));
            }

            var fakeId = Console.ReadLine().Trim();

            inhabitants
                .FindAll(x => x.Id.EndsWith(fakeId))
                .ForEach(inhabitant => Console.WriteLine(inhabitant.Id));
        }
    }
}
