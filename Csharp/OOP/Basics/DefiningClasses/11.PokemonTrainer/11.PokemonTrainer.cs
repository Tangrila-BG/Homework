using System;
using System.Collections.Generic;

namespace Csharp.OOP.Basics.DefiningClasses._11.PokemonTrainer
{
    public static partial class _11PokemonTrainer
    {
        public static void Solution()
        {
            while (true)
            {
                Queue<string> input = new Queue<string>(Console.ReadLine().Split());


                if (input.Peek().ToLower() == "tournament")
                {
                    while (true)
                    {
                        string fight = Console.ReadLine().ToLower();

                        if (fight == "end")
                            break;

                        Trainer.Tournament(fight);

                    }

                    break;
                }

                string trainerName = input.Dequeue();
                string pokemonName = input.Dequeue();
                string pokemonElement = input.Dequeue();
                int pokemonHealth = Convert.ToInt32(input.Dequeue());
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!Trainer.Exist(trainerName))
                {
                    new Trainer(trainerName)
                        .CatchPokemon(pokemon);
                }
                else
                {
                    Trainer.FindTrainer(trainerName)
                        .CatchPokemon(pokemon);
                }

            }

            Trainer.PrintTrainersStats();
        }
    }

}
