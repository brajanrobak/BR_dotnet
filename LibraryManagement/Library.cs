
namespace LibraryManagement;

public class Library : IBookOperations
{
    private readonly List<Book> _books = new List<Book>();

    public void AddBook(Book book)
    {
        _books.Add(book);
        Console.WriteLine($"Dodano do biblioteki: {book.Title}");
    }

    public void ListAvailableBooks()
    {
        var availableBooks = _books.Where(b => b.IsAvailable).ToList();
        
        if (availableBooks.Count == 0)
        {
            Console.WriteLine("\nBrak dostępnych książek w bibliotece.");
            return;
        }

        Console.WriteLine("\n--- Dostępne książki ---");
        foreach (var book in availableBooks)
        {
            book.DisplayInfo();
        }
        Console.WriteLine("------------------------\n");
    }

    public void BorrowBook(int bookId, string borrowerName)
    {
        var book = _books.FirstOrDefault(b => b.Id == bookId);
        
        if (book == null)
            throw new ArgumentException($"Nie znaleziono książki o ID: {bookId}");

        if (!book.IsAvailable)
            throw new BookAlreadyBorrowedException($"Książka '{book.Title}' jest już wypożyczona.");

        book.MarkAsBorrowed();
        Console.WriteLine($"Sukces: Książka '{book.Title}' została wypożyczona przez użytkownika: {borrowerName}.");
    }

    public void ReturnBook(int bookId)
    {
        var book = _books.FirstOrDefault(b => b.Id == bookId);
        
        if (book == null)
            throw new ArgumentException($"Nie znaleziono książki o ID: {bookId}");

        if (book.IsAvailable)
            throw new BookNotBorrowedException($"Książka '{book.Title}' nie jest wypożyczona, więc nie można jej zwrócić.");

        book.MarkAsReturned();
        Console.WriteLine($"Sukces: Książka '{book.Title}' została zwrócona do biblioteki.");
    }
}