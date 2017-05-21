using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _05Phonebook
        {
            static void Solution()
            {
                SortedList<string, string> phonebook = new SortedList<string, string>();

                while (true)
                {
                    var input = Console.ReadLine().Split('-');

                    if (input[0] == "search")
                    {
                        while (true)
                        {
                            var secondInput = Console.ReadLine();

                            if (secondInput.ToLower() == "stop")
                                break;

                            if (phonebook.ContainsKey(secondInput))
                                Console.WriteLine($"{secondInput} -> {phonebook[secondInput]}");

                            else
                                Console.WriteLine($"Contact {secondInput} does not exist.");
                        }
                        break;
                    }

                    if (!phonebook.ContainsKey(input[0]))
                        phonebook.Add(input[0], input[1]);
                    else
                        phonebook[input[0]] = input[1];
                }
            }
        }
    }
}
