using App1.AbstractTypes;
using App1.ConcreateTypes;
using App1.Exceptions;
using App1.Services;

namespace App1.Logic
{
    public class Inventory
    {
        private readonly Dictionary<string, Book> _books = new();
        public void AddBook(Book book)
        {
            if (_books.ContainsKey(book.ISBN))
            {
                throw new BookAlreadyExistsException(book.ISBN);
            }
            _books[book.ISBN] = book;
            Console.WriteLine($"Quantum book store: Book added - {book.Title}");
        }
        public List<Book> RemoveOutdatedBooks(int maxYears)
        {
            int currentYear = DateTime.Now.Year;
            var outdated = _books.Values
                .Where(b => currentYear - b.PublishedYear > maxYears)
                .ToList();

            foreach (var book in outdated)
            {
                _books.Remove(book.ISBN);
                Console.WriteLine($"Quantum book store: Removed outdated book - {book.Title}");
            }

            return outdated;
        }

        public decimal BuyBook(Book book, int quantity)
        {
            // 1. Check purchasable
            if (book is not IPurchasable purchasable)
            {
                throw new BookNotForSaleException(book.Title);
            }

            // 2. If it's a paper book, check stock
            if (book is PaperBook paperBook)
            {
                if (paperBook.Stock < quantity)
                {
                    throw new OutOfStockException(paperBook.Title, quantity, paperBook.Stock);
                }

                if (book is IShippable shippable && shippable.IsShipable)
                {
                    Console.Write("Quantum book store: Enter shipping address: ");
                    string? address = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(address))
                    {
                        throw new MissingShippingAddressException();
                    }
                    ShippingService.Ship(book,address);
                }
                paperBook.Stock -= quantity;
            }

            // 3. If it's an eBook, check if sendable
            if (book is EBook ebook)
            {
                if (book is ISendable sendable && sendable.IsSendable)
                {
                    Console.Write("Quantum book store: Enter email address: ");
                    string? email = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(email)|| !email.Contains("@"))
                    {
                        throw new InvalidEmailException();
                    }

                    MailService.Send(book,email);
                }
            }

            // 4. Return total price
            decimal total = purchasable.Price * quantity;
            Console.WriteLine($"Quantum book store: Purchase complete. Total paid: {total}");
            return total;
        }

    }
}
