using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public class PaperBook : Book
    {
        private readonly IShippingService _shippingService; 
        public int Stock { get; private set ;}

        public PaperBook(string isbn , string title , int yearPublished, double price , int stock , IShippingService shippingService)
            :base(isbn , title , yearPublished , price)
        {
            Stock = stock;
            _shippingService = shippingService;
        }

        public override void Buy(int quantity, string email, string address)
        {
            if (!IsAvailable(quantity))
                throw new Exception("Sorry , Not enough stock.");
            Stock -= quantity;
            Console.WriteLine($"Bought {quantity} copy(ies) of {Title} with price: {quantity * Price}");
            _shippingService.Send(address, Title);
        }

        public override bool IsAvailable(int quantity)
        {
            return Stock >= quantity; 
        }
    }
}
