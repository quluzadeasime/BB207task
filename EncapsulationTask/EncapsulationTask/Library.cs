using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace EncapsulationTask
{
    internal class Library
    {
        
        public Book [] Books = new Book[0];

        public void AddBook(Book book)
        {
            Array.Resize (ref Books, Books.Length+1);
            Books[Books.Length-1] = book;
        }
        public Book[] ShowAllBooks() 
        {
            return Books;
        }

        public Book[] GetFilteredBooks(int minPrice,int maxPrice)
        {
            Book[] books = new Book [0];
            foreach (Book book in Books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref books, books.Length + 1);
                    books[books.Length - 1] = book;
                }
            }
            return books;
        }

        public Book[] GetFilteredBoooks(string genre)
        {
            Book[] filteredBooks = new Book[0];
            foreach (Book book in Books)
            {
                if (book.Genre == genre)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            
            return filteredBooks;
        }

    }
}
