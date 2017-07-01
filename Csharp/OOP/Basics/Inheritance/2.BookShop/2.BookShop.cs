using System;
using System.Text;

namespace Csharp.OOP.Basics.Inheritance._2.BookShop
{
    public static class _2BookShop
    {
        public static void Solution()
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = Double.Parse(Console.ReadLine());

                Book book = new Book(author, title, price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        private class Book
        {
            private string _title;
            private string _author;
            private double _price;

            public string Title
            {
                get { return _title; }
                set
                {
                    if (value.Length < 3)
                        throw new ArgumentException("Title not valid!");

                    _title = value;
                }
            }

            public string Author
            {
                get { return _author; }
                set
                {
                    var names = value.Split();

                    if (Char.IsDigit(names[1][0]))
                        throw new ArgumentException("Author not valid!");

                    _author = value;
                }
            }

            public virtual double Price
            {
                get { return _price; }
                set
                {
                    if (value < 1)
                        throw new ArgumentException("Price not valid!");

                    _price = value;
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Type: ").Append(this.GetType().Name)
                    .Append(Environment.NewLine)
                    .Append("Title: ").Append(this.Title)
                    .Append(Environment.NewLine)
                    .Append("Author: ").Append(this.Author)
                    .Append(Environment.NewLine)
                    .Append("Price: ").Append(this.Price)
                    .Append(Environment.NewLine);

                return sb.ToString();

            }

            public Book(string author, string title, double price)
            {
                this.Author = author;
                this.Title = title;
                this.Price = price;
            }
        }

        class GoldenEditionBook : Book
        {
            public override double Price
            {
                get { return base.Price; }
                set { base.Price = value * 1.3; }
            }

            public GoldenEditionBook(string author, string title, double price) : base(author, title, price)
            {
            }
        }
    }
}
