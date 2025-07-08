namespace App1.Exceptions
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException(string title, int requested, int available)
            : base($"Quantum book store: Not enough stock for '{title}'. Requested: {requested}, Available: {available}")
        {
        }
    }
}
