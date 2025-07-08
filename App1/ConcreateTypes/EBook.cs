using App1.AbstractTypes;

namespace App1.ConcreateTypes
{
    public class EBook : Book, IPurchasable, ISendable
    {
        public decimal Price { get; set; }
        public bool IsSendable { get; set; }
        public EBook(string isbn, string title, int year, string author, decimal price, bool isSendable)
        : base(isbn, title, year, author)
        {
            Price = price;
            IsSendable = isSendable;
        }
    }
}
