// Homework 1 - Book class
// Arrays + Classes together

Book[] books =
{
    new Book("Suç ve Ceza", "Dostoyevski", 687),
    new Book("Sefiller", "Victor Hugo", 1488),
    new Book("Küçük Prens", "Antoine de Saint-Exupéry", 96)
};

Console.WriteLine("All books:");
foreach (Book b in books)
{
    Console.WriteLine("- " + b.Info());
}

Book longest = books[0];
foreach (Book b in books)
{
    if (b.Pages > longest.Pages)
        longest = b;
}

Console.WriteLine();
Console.WriteLine("Book with the most pages:");
Console.WriteLine("- " + longest.Info());

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
            if (value <= 0)
                throw new ArgumentException("Pages must be greater than 0.");
            pages = value;
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
