using App1.AbstractTypes;

namespace App1.Services
{
    public class ShippingService
    {
        public static void Ship(Book book,string address)
        {
            Console.WriteLine("Quantum book store: Shipping process started...");
            Console.WriteLine($"Quantum book store: Book '{book.Title}' by {book.Author} is being shipped to: {address}");
            Console.WriteLine("Quantum book store: Shipment request sent successfully.");
        }
    }
}
