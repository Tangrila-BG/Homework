using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Csharp.OOP.Basics.Inheritance._4.MordorCrueltyPlan
{
    public static class _4MordorCrueltyPlan
    {
        public static void Solution()
        {
            var food = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var gandalf = new Gandalf();

            foreach (var s in food)
            {
                var f = FoodFactory.ProduceFood(s);
                gandalf.Eat(f);
            }
            Console.WriteLine(gandalf);
        }

        class Gandalf
        {
            private int Happiness { get; set; }

            private Mood Mood => MoodFactory.ProduceMood(this.Happiness);

            public void Eat(Food food)
            {
                this.Happiness += food.Happiness;
            }

            public override string ToString()
            {
                return $"{this.Happiness}\n{this.Mood}";
            }
        }

        class FoodFactory
        {
            public static Food ProduceFood(string food)
            {
                switch (food.ToLowerInvariant())
                {
                    case "lembas":
                        return new Lembas();
                    case "cram":
                        return new Cram();
                    case "apple":
                        return new Apple();
                    case "melon":
                        return new Melon();
                    case "honeycake":
                        return new HoneyCake();
                    case "mushrooms":
                        return new Mushrooms();
                    default:
                        return new UnknownFood();
                }
            }
        }

        class MoodFactory
        {
            public static Mood ProduceMood(int happiness)
            {
                if (happiness < -5)
                    return new Angry();

                if (happiness >= -5 && happiness < 0)
                    return new Sad();

                if (happiness >= 0 && happiness < 15)
                    return new Happy();

                return new JavaScript();
            }
        }

        abstract class Food
        {
            public string Name => this.GetType().Name;
            public int Happiness { get; protected set; }
        }

        class Cram : Food
        {
            public Cram()
            {
                this.Happiness = 2;
            }
        }

        class Lembas : Food
        {
            public Lembas()
            {
                this.Happiness = 3;
            }
        }

        class Apple : Food
        {
            public Apple()
            {
                this.Happiness = 1;
            }
        }

        class Melon : Food
        {
            public Melon()
            {
                this.Happiness = 1;
            }
        }

        class HoneyCake : Food
        {
            public HoneyCake()
            {
                this.Happiness = 5;
            }
        }

        class Mushrooms : Food
        {
            public Mushrooms()
            {
                this.Happiness = -10;
            }
        }

        class UnknownFood : Food
        {
            public UnknownFood()
            {
                this.Happiness = -1;
            }
        }

        abstract class Mood
        {
            public string Type => this.GetType().Name;

            public override string ToString()
            {
                return this.Type;
            }
        }

        class Angry : Mood { }
        class Sad : Mood { }
        class Happy : Mood { }
        class JavaScript : Mood { }
    }
}
