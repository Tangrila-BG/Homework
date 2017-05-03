

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            while (t-- > 0)
            {
                var input = Console.ReadLine().Split().ToArray();
                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Isbn = input[4],
                    Price = decimal.Parse(input[5])
                };
                books.Add(book);
            }
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var library = new Library
                {
                    Name = "Pesho",
                    Books = books
                };

            foreach (var book in library.BooksAfterDate(date)
                .Select(x => new {x.Title, x.ReleaseDate})
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }

            public decimal TotalAuthorRevenue(string author)
            {
                return Books.Where(x => x.Author == author).Select(x => x.Price).Sum();
            }

            public List<Book> BooksAfterDate(DateTime date)
            {
                return Books.Where(x => x.ReleaseDate > date).ToList();
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Isbn { get; set; }
            public decimal Price { get; set; }

        }
    }
}
