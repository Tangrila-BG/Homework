using System;
using System.Collections.Generic;
using System.Linq;

namespace Csharp.OOP.Basics.Encapsulation._5.PizzaCalories
{
    public partial class _5PizzaCalories
    {
        private class Pizza
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                private set
                {
                    if (string.IsNullOrEmpty(value) || value.Length > 15)
                        throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");

                    this._name = value;
                }
            }

            public Dough Dough { get; set; }
            public List<Topping> Toppings { get; }

            public double TotalCalories
            {
                get { return this.Dough.CaloriesPerGram + this.Toppings.Sum(t => t.CaloriesPerGram); }
            }

            public void AddTopping(Topping topping)
            {


                this.Toppings.Add(topping);
            }

            public override string ToString()
            {
                return $"{this.Name} - {this.TotalCalories:F2} Calories.";
            }

            public Pizza(string name, int toppingCount)
            {
                if (toppingCount < 0 || toppingCount > 10)
                    throw new ArgumentException("Number of toppings should be in range [0..10].");

                _name = name;
                this.Toppings = new List<Topping>();
            }
        }

    }

}
