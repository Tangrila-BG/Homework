using System;

namespace Csharp.OOP.Advanced.InterfacesAndAbstraction._3Ferrari
{
    class _3Ferrari
    {
        public static void Solution()
        {
            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
            Console.WriteLine(new Ferrari(Console.ReadLine()));
        }
    }
}
