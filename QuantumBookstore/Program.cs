namespace QuantumBookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShippingService shippingService = new ShippingService();
            IEmailService emailService = new MailService();


            BookStore store = new();

            Console.WriteLine("\n========= Add Books ==========\n");

            store.AddBook(new PaperBook("P123", "Clean Code", 2008, 50, 10, shippingService));
            store.AddBook(new EBook("E456", "The Pragmatic Programmer", 1999, 30, "PDF", emailService));
            store.AddBook(new ShowcaseBook("D789", "Design Patterns Demo", 1994, 0));

            Console.WriteLine("\n====================");

            Console.WriteLine("\n========= Buy Book ==========\n");

            store.Buy("P123", 2 , "_", "123 Main St");

            Console.WriteLine();
            store.Buy("E456", 1, "mo@gmail.com", "_");

            Console.WriteLine("\n====================");

            Console.WriteLine("\n========= Remove Book ==========\n");

            store.RemoveOutDatedBooks(20);
            Console.WriteLine("\n====================");

            try
            {
                store.Buy("E456", 50, "mo@gamil.com", "_");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erorr is : {e.Message}");
            }

        }
    }
}
