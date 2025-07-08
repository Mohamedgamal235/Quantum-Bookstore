using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class ShowcaseBook : Book
    {
        public ShowcaseBook(string isbn, string title, int yearPublished, double price)
            : base(isbn, title, yearPublished, price) { }

        public override void Buy(int quantity, string email, string address)
        {
            throw new Exception("These type of books not for sale , Sorry.");
        }

        public override bool IsAvailable(int quantity) => true; 
    }
}
