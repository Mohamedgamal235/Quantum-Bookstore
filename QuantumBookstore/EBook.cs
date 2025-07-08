using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class EBook : Book
    {
        private readonly IEmailService _emailService; 
        public string FileType { get; }

        public EBook(string isbn, string title, int yearPublished, double price , string fileType , IEmailService emailService)
            :base(isbn , title , yearPublished , price)
        {
            FileType = fileType;
            _emailService = emailService; 
        }

        public override void Buy(int quantity, string email, string address)
        {
            Console.WriteLine($"Bought {quantity} copy(ies) of {Title} with price: {quantity * Price}");
            _emailService.Send(email, Title, FileType);
        }

        public override bool IsAvailable(int quantity) => true; // not tell me it has a stock so i consider that is unlimited
    }
}
