
namespace LibraryManagement;

public class BookAlreadyBorrowedException : Exception
{
    public BookAlreadyBorrowedException(string message) : base(message) { }
}

public class BookNotBorrowedException : Exception
{
    public BookNotBorrowedException(string message) : base(message) { }
}