
namespace LibraryManagement;

public class Book
{
    public int Id { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public bool IsAvailable { get; private set; }
    
    public Book(int id, string title, string author)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = true; 
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"[Książka] ID: {Id} | {Title} - {Author} | Dostępna: {(IsAvailable ? "Tak" : "Nie")}");
    }

    public void MarkAsBorrowed() => IsAvailable = false;
    public void MarkAsReturned() => IsAvailable = true;
}