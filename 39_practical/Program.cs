using _39_practical;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Book[] books =
        {
            new Book()
            {
                NameBook = "Гамлет",
                Author = "Шекспір",
                Genres = Book.Genre.historical,
                CountPapers = 250,
                Year = 1993
            },

    new Book()
    {
        NameBook = "Дракула",
        Author = "Байрон",
        Genres = Book.Genre.horror,
        CountPapers = 420,
        Year = 2002
    },

    new Book()
    {
        NameBook = "Франкенштейн",
        Author = "Мері Шеллі",
        Genres = Book.Genre.horror,
        CountPapers = 180,
        Year = 1998
    },

    new Book()
    {
        NameBook = "Айвенго",
        Author = "Вальтер Скотт",
        Genres = Book.Genre.historical,
        CountPapers = 350,
        Year = 2005
    },

    new Book()
    {
        NameBook = "Тарас Бульба",
        Author = "Микола Гоголь",
        Genres = Book.Genre.historical,
        CountPapers = 120,
        Year = 1993
    }
        };

        var Book1 = from book in books
                    where book.CountPapers > 100
                    select book;

        Console.WriteLine(books.All(i => i.CountPapers > 100));
        Console.WriteLine(books.All(i => i.Genres == Book.Genre.historical || i.Genres == Book.Genre.horror));
        Console.WriteLine(books.Any(i => i.Genres == Book.Genre.horror));
        Console.WriteLine(books.Any(i => i.Author == "Шекспір"));

        Console.WriteLine(books.Select(b => b.Author).Contains("Байрон"));
        Console.WriteLine(books.FirstOrDefault(i => i.Year == 1993));
        Console.WriteLine(books.LastOrDefault(i => i.Year == 2002));
    }
}