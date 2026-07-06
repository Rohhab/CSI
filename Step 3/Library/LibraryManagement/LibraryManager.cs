namespace LibraryManagement;

public class LibraryManager<T>
{
    public List<LibraryItem<T>> Items { get; } = new();
}
