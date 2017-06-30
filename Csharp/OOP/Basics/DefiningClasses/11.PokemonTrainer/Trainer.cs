using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.DefiningClasses._11.PokemonTrainer
{
    public static partial class _11PokemonTrainer
    {
        private class Trainer
        {
            private string _name;
            private int _numBadges = 0;
            private List<Pokemon> _pokemons = new List<Pokemon>();
            public static List<Trainer> _trainers = new List<Trainer>();

            public Trainer(string name, int numBadges)
            {
                _name = name;
                _numBadges = numBadges;
            }

            public Trainer(string name)
            {
                _name = name;
                _trainers.Add(new Trainer(_name, _numBadges));
            }

            public void CatchPokemon(Pokemon pokemon)
            {
                var trainer = _trainers.First(t => t._name == _name);
                trainer._pokemons.Add(pokemon);
            }

            public static bool Exist(string name)
            {
                return _trainers.FirstOrDefault(t => t._name == name) != null;
            }

            public static Trainer FindTrainer(string name)
            {
                return _trainers.FirstOrDefault(t => t._name == name);
            }

            public static void Tournament(string element)
            {
                foreach (Trainer trainer in _trainers)
                {
                    bool hasPokemonWithElement = false;
                    var pokemons = trainer._pokemons.GetEnumerator();

                    while (pokemons.MoveNext())
                    {
                        var current = pokemons.Current;
                        if (current.Element.ToLower().Equals(element))
                        {
                            hasPokemonWithElement = true;
                            break;
                        }
                    }
                    pokemons.Dispose();
                    if (hasPokemonWithElement)
                    {
                        trainer.AddBadge();
                    }
                    else
                    {
                        /* take 10 health from every pokemon where
                        * his trainer has no pokemon with element
                        */
                        trainer._pokemons.ForEach(p => p.TakeDamage());
                    }
                }
                // remove all dead pokemons
                _trainers.ForEach(t => t._pokemons.RemoveAll(p => p.Health <= 0));

            }

            private void AddBadge()
            {
                _numBadges += 1;
            }

            public static void PrintTrainersStats()
            {

                _trainers
                    .OrderByDescending(t => t._numBadges)
                    .ToList()
                    .ForEach(t => Console.WriteLine($"{t._name} {t._numBadges} {t._pokemons.Count}"));
            }
        }
    }

}
