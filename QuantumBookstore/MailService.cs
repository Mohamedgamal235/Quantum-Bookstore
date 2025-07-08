using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class MailService : IEmailService
    {
        public void Send(string email, string bookTitle, string fileType)
        {
            Console.WriteLine($"Sending the book : {bookTitle} with file type {fileType} to email: {email}");
        }
    }
}
