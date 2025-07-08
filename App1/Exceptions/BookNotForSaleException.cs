namespace App1.Exceptions
{
    public class BookNotForSaleException : Exception
    {
        public BookNotForSaleException(string title)
            : base($"Quantum book store: The book '{title}' is not for sale.")
        {
        }
    }
}
