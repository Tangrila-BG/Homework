namespace Csharp.OOP.Basics.Inheritance._4.MordorCrueltyPlan
{
    
        abstract class Mood
        {
            public string Type => this.GetType().Name;

            public override string ToString()
            {
                return this.Type;
            }
        }
    
}
