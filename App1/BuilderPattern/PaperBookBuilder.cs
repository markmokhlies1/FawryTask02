using App1.ConcreateTypes;

namespace App1.BuilderPattern
{
    public class PaperBookBuilder : BookBuilder<PaperBookBuilder, PaperBook>
    {
        private decimal price;
        private int stock;
        private bool isShippable;

        public PaperBookBuilder SetPrice(decimal price)
        {
            this.price = price;
            return this;
        }

        public PaperBookBuilder SetStock(int stock)
        {
            this.stock = stock;
            return this;
        }

        public PaperBookBuilder SetShippable(bool isShippable)
        {
            this.isShippable = isShippable;
            return this;
        }

        public override PaperBook Build()
        {
            return new PaperBook(isbn, title, publishedYear, author, price, stock, isShippable);
        }
    }
}
