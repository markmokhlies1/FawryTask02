namespace App1.Exceptions
{
    public class BookAlreadyExistsException : Exception
    {
        public BookAlreadyExistsException(string isbn)
            : base($"Quantum book store: Book with ISBN '{isbn}' already exists.")
        {
        }
    }
}
