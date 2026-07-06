namespace LibraryManagement;

public class Librarian
{
    public void AddItem<T>(List<LibraryItem<T>> collection, LibraryItem<T> item)
        => collection.Add(item);

    public void RemoveItem<T>(List<LibraryItem<T>> collection, LibraryItem<T> item)
        => collection.Remove(item);
}
