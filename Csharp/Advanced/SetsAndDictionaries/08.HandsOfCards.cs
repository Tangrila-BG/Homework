using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Advanced.SetsAndDictionaries
{
    public partial class SetsAndDictionaries
    {
        public static class _08HandsOfCards
        {
            public static void Solution()
            {
                Dictionary<string, int> players = new Dictionary<string, int>();
                Dictionary<string, HashSet<string>> playersHands = new Dictionary<string, HashSet<string>>();

                while (true)
                {
                    var input = Console.ReadLine()
                        .Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (input[0].ToLower() == "joker")
                        break;

                    var name = input[0];

                    if (!playersHands.ContainsKey(name))
                        playersHands.Add(name, new HashSet<string>());

                    for (int i = 1; i < input.Length; i++)
                    {
                        input[i] = input[i].Trim();
                        playersHands[name].Add(input[i]);

                    }
                }

                foreach (var kvp in playersHands)
                {
                    var score = 0;
                    var name = kvp.Key;

                    foreach (string card in kvp.Value)
                    {
                        int digitPower;
                        int.TryParse(string.Join("", card.Where(char.IsDigit)), out digitPower);

                        var letterPower = card.Where(char.IsLetter).ToArray();

                        if (letterPower.Length > 1)
                            score += Power(letterPower);
                        else
                            score += digitPower * Power(letterPower);

                    }

                    if (!players.ContainsKey(name))
                        players.Add(name, score);
                    else
                        players[name] += score;
                }

                foreach (var kvp in players)
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            private static int Power(char[] letters)
            {
                var typePower = 0;
                var cardPower = 0;
                var card = letters[0];

                if (letters.Length > 1)
                {
                    if (card == 'J')
                        cardPower = 11;
                    else if (card == 'Q')
                        cardPower = 12;
                    else if (card == 'K')
                        cardPower = 13;
                    else if (card == 'A')
                        cardPower = 14;
                    card = letters[1];
                }

                if (card == 'C')
                    typePower = 1;
                else if (card == 'D')
                    typePower = 2;
                else if (card == 'H')
                    typePower = 3;
                else if (card == 'S')
                    typePower = 4;

                if (cardPower > 0)
                    return typePower * cardPower;

                return typePower;
            }
        }
    }
}
