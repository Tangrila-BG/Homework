﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.Advanced.ManualStringProcessing
{
    public partial class ManualStringProcessing
    {
        public static class _15MelrahShake
        {
            public static void Solution()
            {
                var sentence = Console.ReadLine();
                var pattern = Console.ReadLine();

                // Console.WriteLine(ShakeRecursive(sentence, pattern));
                while (true)
                {
                    var firstIndex = sentence.IndexOf(pattern);
                    var secondIndex = sentence.LastIndexOf(pattern);

                    var canShake = firstIndex > -1
                        && secondIndex > -1
                        && pattern.Length > 0;

                    if (!canShake)
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(sentence);
                        break;
                    }

                    // remove left most pattern
                    sentence = sentence.Remove(firstIndex, pattern.Length);
                    // remove right most pattern
                    sentence = sentence.Remove(secondIndex - pattern.Length, pattern.Length);
                    // remove middle char from pattern
                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
            }
            // Recursive solution 
            public static string ShakeRecursive(string sentence, string pattern)
            {
                var firstIndex = sentence.IndexOf(pattern);
                var secondIndex = sentence.LastIndexOf(pattern);

                var canShake = firstIndex > -1
                               && secondIndex > -1
                               && pattern.Length > 0;

                if (!canShake)
                {
                    Console.WriteLine("No shake.");
                    return sentence;
                }

                // remove left most pattern
                sentence = sentence.Remove(firstIndex, pattern.Length);
                // remove right most pattern
                sentence = sentence.Remove(secondIndex - pattern.Length, pattern.Length);
                // remove middle char from pattern
                pattern = pattern.Remove(pattern.Length / 2, 1);

                Console.WriteLine("Shaked it.");

                return ShakeRecursive(sentence, pattern);
            }
        }
    }
}
