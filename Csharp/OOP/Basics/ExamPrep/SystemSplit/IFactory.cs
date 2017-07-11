namespace Csharp.OOP.Basics.ExamPrep.SystemSplit
{
    interface IFactory<out TProduct>
    {
        TProduct GetInstance(string[] parameters);
    }
}
