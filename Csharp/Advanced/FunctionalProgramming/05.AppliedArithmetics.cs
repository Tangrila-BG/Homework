using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.FunctionalProgramming
{
    public partial class FunctionalProgramming
    {
        public static class _05AppliedArithmetics
        {
            public static void Solution()
            {
                var numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                while (true)
                {
                    var operation = Console.ReadLine().Trim();

                    if (operation.Equals("end", StringComparison.OrdinalIgnoreCase))
                        break;

                    Action<IEnumerable<int>> print = x => Console.WriteLine(string.Join(" ", x));
                    Func<IEnumerable<int>, IEnumerable<int>> add = x => x.Select(y => y + 1);
                    Func<IEnumerable<int>, IEnumerable<int>> subtract = x => x.Select(y => y - 1);
                    Func<IEnumerable<int>, IEnumerable<int>> multiply = x => x.Select(y => y * 2);

                    switch (operation)
                    {
                        case "add":
                            numbers = Arithmetics(numbers, add).ToArray();
                            break;

                        case "subtract":
                            numbers = Arithmetics(numbers, subtract).ToArray();
                            break;

                        case "multiply":
                            numbers = Arithmetics(numbers, multiply).ToArray();
                            break;

                        case "print":
                            print(numbers);
                            break;
                    }
                }
            }

            private static IEnumerable<int> Arithmetics(IEnumerable<int> numbers,
                Func<IEnumerable<int>, IEnumerable<int>> operation)
            {
                return operation(numbers);
            }
        }
    }
}
