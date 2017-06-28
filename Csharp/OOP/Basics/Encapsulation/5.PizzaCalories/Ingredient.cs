namespace Csharp.OOP.Basics.Encapsulation._5.PizzaCalories
{
    public partial class _5PizzaCalories
    {
        private abstract class Ingredient
        {
            protected double _weight;
            public double CaloriesPerGram => this.CalculateCalories();

            protected virtual double Weight
            {
                get { return this._weight; }
                set { this._weight = value; }
            }

            private double BaseModifier => 2;
            protected double CustomModifier { get; set; }

            private double CalculateCalories()
            {
                return (this.Weight * this.BaseModifier) * this.CustomModifier;
            }
        }

    }

}
