using App1.AbstractTypes;

namespace App1.ConcreateTypes
{
    public class PaperBook : Book, IPurchasable, IShippable
    {
        public int Stock { get; set; }
        public decimal Price { get;set; }
        public bool IsShipable { get; set; }
        public PaperBook(string isbn, string title, int year, string author, decimal price, int stock, bool isShippable)
        : base(isbn, title, year, author)
        {
            Price = price;
            Stock = stock;
            IsShipable = isShippable;
        }
    }
}
