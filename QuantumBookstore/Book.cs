using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstore
{
    public abstract class Book
    {
        public string ISBN { get;  }
        public string Title { get; }
        public int YearPublished { get; }
        public double Price { get; }

        protected Book(string isbn , string title , int yearPublished , double price)
        {
            ISBN = isbn;
            Title = title;
            YearPublished = yearPublished;
            Price = price; 
        }

        public abstract void Buy(int quantity , string email , string address);
        public abstract bool IsAvailable(int quantity);

    }
}
