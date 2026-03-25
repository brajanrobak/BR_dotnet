using System;
using LibraryManagement;

var library = new Library();

library.AddBook(new Book(1, "Wladca Pierscieni", "J.R.R. Tolkien"));
library.AddBook(new EBook(2, "Harry Potter", "J.K Rowling", "PDF"));

bool exit = false;

while (!exit)
{
    Console.WriteLine("\n--- SYSTEM ZARZĄDZANIA BIBLIOTEKĄ ---");
    Console.WriteLine("1. Wyświetl dostępne książki");
    Console.WriteLine("2. Wypożycz książkę");
    Console.WriteLine("3. Zwróć książkę");
    Console.WriteLine("4. Dodaj nową książkę");
    Console.WriteLine("0. Wyjdź");
    Console.Write("Wybierz opcję: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            library.ListAvailableBooks();
            break;

        case "2":
            Console.Write("Podaj ID książki do wypożyczenia: ");
            if (int.TryParse(Console.ReadLine(), out int borrowId))
            {
                Console.Write("Podaj swoje imię: ");
                string name = Console.ReadLine();
                try {
                    library.BorrowBook(borrowId, name);
                } catch (Exception ex) {
                    Console.WriteLine($"BŁĄD: {ex.Message}");
                }
            }
            break;

        case "3":
            Console.Write("Podaj ID książki do zwrotu: ");
            if (int.TryParse(Console.ReadLine(), out int returnId))
            {
                try {
                    library.ReturnBook(returnId);
                } catch (Exception ex) {
                    Console.WriteLine($"BŁĄD: {ex.Message}");
                }
            }
            break;

        case "4":
            Console.Write("Podaj tytuł: ");
            string title = Console.ReadLine();
            Console.Write("Podaj autora: ");
            string author = Console.ReadLine();
            int nextId = new Random().Next(100, 999); 
            library.AddBook(new Book(nextId, title, author));
            break;

        case "0":
            exit = true;
            break;

        default:
            Console.WriteLine("Niepoprawny wybór.");
            break;
    }
}