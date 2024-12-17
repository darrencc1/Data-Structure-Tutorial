using System;
using System.Collections.Generic;

class LibrarySystem
{
    static void Main()
    {
        // Create a HashSet to store borrowed book titles
        HashSet<string> borrowedBooks = new HashSet<string>();

        // Simulate adding books to the borrowed list
        borrowedBooks.Add("The Great Gatsby");
        borrowedBooks.Add("1984");
        borrowedBooks.Add("To Kill a Mockingbird");
        borrowedBooks.Add("1984"); // Duplicate entry (will be ignored)

        Console.WriteLine("Books currently borrowed:");

        // Display all borrowed books
        foreach (string book in borrowedBooks)
        {
            Console.WriteLine(book);
        }

        // Simulate returning a book
        Console.WriteLine("\nReturning '1984'...");
        borrowedBooks.Remove("1984");

        // Display updated list of borrowed books
        Console.WriteLine("\nBooks currently borrowed after returning one:");
        foreach (string book in borrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}
