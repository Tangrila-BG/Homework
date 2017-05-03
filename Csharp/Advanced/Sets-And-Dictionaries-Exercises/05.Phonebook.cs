using System;
using System.Collections.Generic;

namespace _05.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> Phonebook = new SortedList<string, string>();

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

                        if (Phonebook.ContainsKey(secondInput))
                            Console.WriteLine($"{secondInput} -> {Phonebook[secondInput]}");
                        else
                            Console.WriteLine($"Contact {secondInput} does not exist.");

                    }
                    break;
                }
                if (!Phonebook.ContainsKey(input[0]))
                    Phonebook.Add(input[0], input[1]);
                else
                    Phonebook[input[0]] = input[1];
            }
        }
    }
}
