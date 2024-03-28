using System;
using System.Xml.Linq;

namespace EncapsulationTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("1984", "5", 7.90, 4, "Drama");
            Book book2 = new Book("Crime and Punishment", "4", 17.90, 6, "Drama");
            Book book3 = new Book("Ten little niggers", "7", 13.50, 6, "Detective");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("All Books:");
            Book[] books = library.ShowAllBooks();
            for (int i = 0; i < books.Length; i++)
            {
                books[i].Showinfo();
            }

            Console.WriteLine("*************************");
            Console.WriteLine("Filtered books: ");
            int minPrice = 8;
            int maxPrice = 16;
            Book[] filteredBooks = library.GetFilteredBooks(minPrice, maxPrice);
            foreach (Book book in filteredBooks)
            {
                book.Showinfo();
            }
            Console.WriteLine("************************");
            Console.WriteLine("Filtered books by genre:");
            string filter = "Drama";
            Book[] filteredBooksByGenre = library.GetFilteredBoooks(filter);
            foreach (Book book in filteredBooksByGenre)
            {
                book.Showinfo();
            }
        }
    }
}
