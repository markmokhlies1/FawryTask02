namespace App1.Exceptions
{
    public class MissingShippingAddressException : Exception
    {
        public MissingShippingAddressException()
            : base("Quantum book store: Address is required for shipping.")
        {
        }
    }
}
