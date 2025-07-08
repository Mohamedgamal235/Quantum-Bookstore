using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class ShippingService : IShippingService
    {
        public void Send(string address, string bookTitle)
        {
            Console.WriteLine($"Sending the book: {bookTitle} to address: {address}");
        }
    }
}
