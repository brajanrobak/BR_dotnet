
namespace LibraryManagement;

public class EBook : Book
{
    public string FileFormat { get; private set; }
    
    public EBook(int id, string title, string author, string fileFormat) 
        : base(id, title, author)
    {
        FileFormat = fileFormat;
    }
    
    public override void DisplayInfo()
    {
        Console.WriteLine($"[E-Book] ID: {Id} | {Title} - {Author} | Format: {FileFormat} | Dostępna: {(IsAvailable ? "Tak" : "Nie")}");
    }
}