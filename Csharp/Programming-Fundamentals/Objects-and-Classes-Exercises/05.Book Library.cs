using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            while (t-- > 0)
            {
                var input = Console.ReadLine().Split().ToArray();
                var book = new Book
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = input[3],
                    Isbn = input[4],
                    Price = decimal.Parse(input[5])
                };
                books.Add(book);
            }
            var library = new Library()
            {
                Name = "Pesho",
                Books = books
            };
            foreach (var author in library.Books
                .Select(x => new {x.Author, Revenue = library.TotalAuthorRevenue(x.Author)})
                .Distinct()
                .OrderByDescending(x => x.Revenue)
                .ThenBy(x => x.Author))
            {
                Console.WriteLine($"{author.Author} -> {author.Revenue:F2}");
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
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public string ReleaseDate { get; set; }
            public string Isbn { get; set; }
            public decimal Price { get; set; }

        }
    }
}
