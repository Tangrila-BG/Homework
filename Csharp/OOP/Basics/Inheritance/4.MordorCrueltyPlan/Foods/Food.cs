namespace Csharp.OOP.Basics.Inheritance._4.MordorCrueltyPlan.Foods
{
    
        abstract class Food
        {
            public string Name => this.GetType().Name;
            public int Happiness { get; protected set; }
        }
    
}
