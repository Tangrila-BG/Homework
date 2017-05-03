using System;
using System.Collections.Generic;

namespace _02.AdvertisementMessage
{
    class Program
    {
        public static readonly string[] Phrases =
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
        public static readonly string[] Events =
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
        public static readonly string[] Authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

        public static readonly string[] Cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

        static void Main(string[] args)
        {
            Random random = new Random();
            var t = int.Parse(Console.ReadLine());
            List<string[]> messages = new List<string[]>
            {
                Phrases, Events, Authors, Cities
            };
            for (int i = 0; i < t; i++)
            {
                var advert = "";
                for (int j = 0; j < 4; j++)
                {
                    var messageIndex = random.Next(0, messages[j].Length);
                    if (j == 3)
                        advert += " -";
                    advert += " " + messages[j][messageIndex];
                }
                Console.WriteLine(advert.Trim());
            }
        }
    }
}
