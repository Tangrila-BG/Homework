using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _01ActionPrint
        {
            public static void Solution()
            {
                Console.ReadLine().Split().ToList()
                    .ForEach(PrintNames().Invoke);
            }

            static Action<string> PrintNames()
            {
                return Console.WriteLine;
            }
        }
    }
}
