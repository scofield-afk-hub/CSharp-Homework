using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    private int pages;

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
                pages = value;
            else
                throw new ArgumentException("Invalid page number");
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}

class Program
{
    static void Main()
    {
        Book[] books =
        {
            new Book("Suc ve Ceza", "Dostoyevski", 687),
            new Book("1984", "George Orwell", 328),
            new Book("The Hobbit", "J.R.R. Tolkien", 310)
        };

        Book maxBook = books[0];

        foreach (Book book in books)
        {
            Console.WriteLine(book.Info());

            if (book.Pages > maxBook.Pages)
                maxBook = book;
        }

        Console.WriteLine("\nBook with the most pages:");
        Console.WriteLine(maxBook.Info());
    }
}