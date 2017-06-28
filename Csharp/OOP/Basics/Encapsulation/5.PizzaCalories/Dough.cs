using System;

namespace Csharp.OOP.Basics.Encapsulation._5.PizzaCalories
{
    public partial class _5PizzaCalories
    {
        private class Dough : Ingredient
        {
            private FlourType _flourType;
            private BakingTechnique _bakingTechnique;

            protected sealed override double Weight
            {
                get { return _weight; }
                set
                {
                    if (value < 1 || value > 200)
                        throw new ArgumentException("Dough weight should be in the range [1..200]");

                    _weight = value;
                }
            }

            public Dough(string flourType, string technique, double weight) : this(flourType, technique)
            {
                this.Weight = weight;
            }

            private Dough(string flourType, string technique)
            {
                if (!FlourType.TryParse(flourType, true, out FlourType type))
                    throw new ArgumentException("Invalid type of dough.");

                if (!BakingTechnique.TryParse(technique, true, out BakingTechnique bakingTechnique))
                    throw new ArgumentException("Invalid type of dough.");

                this._flourType = type;
                this._bakingTechnique = bakingTechnique;
                this.CustomModifier = type == FlourType.White ? 1.5 : 1;

                if (bakingTechnique == BakingTechnique.Crispy)
                    this.CustomModifier *= 0.9;
                else if (bakingTechnique == BakingTechnique.Chewy)
                    this.CustomModifier *= 1.1;
                else
                    this.CustomModifier *= 1;
            }

            private enum FlourType
            {
                White = 0,
                Wholegrain = 1
            }

            private enum BakingTechnique
            {
                Crispy = 0,
                Chewy = 1,
                Homemade = 2
            }
        }

    }

}
