using App1.AbstractTypes;

namespace App1.Services
{
    public class MailService
    {
        public static void Send(Book book,string email) 
        {
            Console.WriteLine("Quantum book store: Email delivery started...");
            Console.WriteLine($"Quantum book store: Book '{book.Title}' by {book.Author} is being sent to: {email}");
            Console.WriteLine("Quantum book store: Email sent successfully.");
        }
    }
}
