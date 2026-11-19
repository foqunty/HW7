class Book
{
    private int pages;

    public string Title { get; set; }
    public string Author { get; set; }

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
                pages = value;
            else
                throw new ArgumentException("Pages must be > 0");
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
        return Title + " by " + Author + ", " + Pages + " pages";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book[] books = new Book[3];
        books[0] = new Book("Suç ve Ceza", "Dostoyevski", 687);
        books[1] = new Book("Sefiller", "Victor Hugo", 1488);
        books[2] = new Book("Küçük Prens", "Saint-Exupery", 96);

        foreach (Book b in books)
        {
            Console.WriteLine(b.Info());
        }

        Book max = books[0];
        foreach (Book b in books)
        {
            if (b.Pages > max.Pages)
                max = b;
        }

        Console.WriteLine();
        Console.WriteLine("Most pages: " + max.Info());
    }
}
