namespace App1.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException()
            : base("Quantum book store: Email is required for sending.")
        {
        }
    }
}
