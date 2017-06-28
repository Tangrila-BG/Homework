using System;

namespace Csharp.OOP.Basics.Encapsulation._5.PizzaCalories
{
    public partial class _5PizzaCalories
    {
        private class Topping : Ingredient
        {
            private ToppingType _toppingType;

            protected sealed override double Weight
            {
                get { return this._weight; }
                set
                {
                    if (value < 1 || value > 50)
                        throw new ArgumentException(this._toppingType + " weight should be in the range [1..50].");

                    this._weight = value;
                }
            }

            public Topping(string type, double weight) : this(type)
            {
                this.Weight = weight;
            }

            private Topping(string type)
            {
                if (!ToppingType.TryParse(type, true, out ToppingType toppingType))
                    throw new ArgumentException($"Cannot place {type} on top of your pizza.");

                this._toppingType = toppingType;

                if (toppingType == ToppingType.Meat)
                    this.CustomModifier = 1.2;
                else if (toppingType == ToppingType.Veggies)
                    this.CustomModifier = 0.8;
                else if (toppingType == ToppingType.Cheese)
                    this.CustomModifier = 1.1;
                else
                    this.CustomModifier = 0.9;
            }

            private enum ToppingType
            {
                Meat = 0,
                Veggies = 1,
                Cheese = 2,
                Sauce = 3
            }
        }

    }

}
