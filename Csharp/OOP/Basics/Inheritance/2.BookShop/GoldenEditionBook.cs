namespace Csharp.OOP.Basics.Inheritance._2.BookShop
{
    public static partial class _2BookShop
    {
        class GoldenEditionBook : Book
        {
            public override decimal Price => base.Price * 1.3m;

            public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
            {
            }
        }
    }
}
