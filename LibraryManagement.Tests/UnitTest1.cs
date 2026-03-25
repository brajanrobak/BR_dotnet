using NUnit.Framework;
using LibraryManagement;
using System;

namespace LibraryManagement.Tests;

public class LibraryTests
{
    [Test]
    public void BorrowBook_WhenAvailable_MarksBookAsBorrowed()
    {
        var library = new Library();
        var book = new Book(1, "Testowa Książka", "Autor");
        library.AddBook(book);
        
        library.BorrowBook(1, "Testowy Czytelnik");
        
        Assert.That(book.IsAvailable, Is.False);
    }

    [Test]
    public void BorrowBook_WhenAlreadyBorrowed_ThrowsException()
    {
        var library = new Library();
        var book = new Book(1, "Testowa Książka", "Autor");
        library.AddBook(book);
        library.BorrowBook(1, "Testowy Czytelnik");
        
        Assert.Throws<BookAlreadyBorrowedException>(() => library.BorrowBook(1, "Inny Czytelnik"));
    }

    [Test]
    public void ReturnBook_WhenBorrowed_MarksBookAsAvailable()
    {
        var library = new Library();
        var book = new Book(1, "Testowa Książka", "Autor");
        library.AddBook(book);
        library.BorrowBook(1, "Testowy Czytelnik");
        
        library.ReturnBook(1);
        
        Assert.That(book.IsAvailable, Is.True);
    }

    [Test]
    public void ReturnBook_WhenNotBorrowed_ThrowsException()
    {
        var library = new Library();
        var book = new Book(1, "Testowa Książka", "Autor");
        library.AddBook(book);
        
        Assert.Throws<BookNotBorrowedException>(() => library.ReturnBook(1));
    }
}