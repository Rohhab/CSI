namespace LibraryManagement;

internal class Program
{
    static void Main(string[] args)
    {
        var librarian = new Librarian();

        var bookManager = new LibraryManager<Book>();

        var book = new LibraryItem<Book>
        {
            Item = new Book { Title = "Clean Code", Description = "A book about writing maintainable software" },
            Title = "Clean Code",
            Description = "A book about writing maintainable software"
        };

        librarian.AddItem(bookManager.Items, book);

        Console.WriteLine("Books:");
        foreach (var item in bookManager.Items)
            Console.WriteLine($"- {item.Title}");
    }
}

public class Book
{
    public string Description { get; set; }
    public string Title { get; set; }
}