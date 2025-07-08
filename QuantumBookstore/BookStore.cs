using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
     public class BookStore
    {
        private readonly Inventory inventory = new Inventory();

        public void AddBook(Book book) => inventory.AddBook(book);

        public List<Book> RemoveOutDatedBooks(int maxYear) => inventory.RemoveOutDatedBooks(maxYear);

        public void Buy(string isbn , int quantity , string email , string address)
        {
            Book? book = inventory.GetBook(isbn);

            if (book == null)
                throw new Exception($"Book with ISBN: {isbn} not found.");

            if (!book.IsAvailable(quantity))
                throw new Exception($"Book with ISBN: {isbn} not enough.");

            book.Buy(quantity, email, address);
        }
    }
}
