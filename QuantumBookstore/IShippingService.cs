using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public interface IShippingService
    {
        void Send(string address, string bookTitle);
    }
}
