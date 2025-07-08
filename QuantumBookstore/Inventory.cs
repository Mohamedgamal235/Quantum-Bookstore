using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class Inventory
    {
        private readonly Dictionary<string, Book> books = new Dictionary<string, Book>();

        public void AddBook(Book book)
        {
            books[book.ISBN] = book;
            Console.WriteLine($"Book with ISBN : {book.ISBN} added.");
        }

        public List<Book> RemoveOutDatedBooks(int maxYear)
        {
            int currentYear = DateTime.Now.Year;
            var outdatedBooks = books.Values.Where(b => currentYear - b.YearPublished > maxYear).ToList();

            foreach(var book in outdatedBooks)
            {
                books.Remove(book.ISBN);
                Console.WriteLine($"Book with ISBN: {book.ISBN} removed."); // for test
            }

            return outdatedBooks; 
        }

        public Book? GetBook(string isbn)
        {
            return books.TryGetValue(isbn, out var book) ? book : null; 
        }
    }
}
