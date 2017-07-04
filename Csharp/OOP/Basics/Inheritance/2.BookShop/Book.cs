using System;
using System.Linq;

namespace Csharp.OOP.Basics.Inheritance._2.BookShop
{
    public static partial class _2BookShop
    {
        private class Book
        {
            private string _title;
            private string _author;
            private decimal _price;

            public string Title
            {
                get { return _title; }
                set
                {
                    if (value.Length <= 3)
                        throw new ArgumentException("Title not valid!");

                    _title = value;
                }
            }

            public string Author
            {
                get { return _author; }
                set
                {
                    var names = value.Trim().Split();

                    if (!names.Any())
                        return;

                    if (Char.IsDigit(names.First()[0]))
                        throw new ArgumentException("Author not valid!");

                    if (Char.IsDigit(names.Last()[0]))
                        throw new ArgumentException("Author not valid!");

                    _author = value;
                }
            }

            public virtual decimal Price
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
                return $"Type: {this.GetType().Name}\n" +
                       $"Title: {this.Title}\n" +
                       $"Author: {this.Author}\n" +
                       $"Price: {this.Price:F1}\n";
            }

            public Book(string author, string title, decimal price)
            {
                this.Author = author;
                this.Title = title;
                this.Price = price;
            }
        }
    }
}
