using System;
using System.Linq;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._4Telephony
{
    class _4Telephony
    {
        public static void Solution()
        {
            var smartphone = new Smartphone();

            Console.ReadLine().Trim().Split().ToList()
                .ForEach(number => smartphone.Call(number));

            Console.ReadLine().Trim().Split().ToList()
                .ForEach(link => smartphone.Browse(link));
        }
    }
}
