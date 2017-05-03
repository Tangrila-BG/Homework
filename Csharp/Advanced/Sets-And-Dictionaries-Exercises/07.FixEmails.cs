using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailBook = new Dictionary<string , string>();
            int t = 0;
            var name = "-1";
            while (true)
            {

                var input = Console.ReadLine();
                if (input.ToLower() == "stop")
                    break;

                if (t % 2 == 0)
                {
                    name = input;
                    emailBook.Add(input , "");
                }
                else if (t % 2 == 1)
                {
                    emailBook[name] = input;
                }


                t++;
                t %= 2;
            }

            foreach (var kvp in emailBook.Where(x => !x.Value.Contains(".us") || x.Value.Contains(".uk")))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
