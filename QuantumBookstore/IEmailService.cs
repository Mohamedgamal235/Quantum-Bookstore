using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public interface IEmailService
    {
        void Send(string email, string bookTitle, string fileType);
    }
}
