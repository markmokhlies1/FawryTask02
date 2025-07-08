using App1.ConcreateTypes;

namespace App1.BuilderPattern
{
    public class EBookBuilder : BookBuilder<EBookBuilder, EBook>
    {
        private decimal price;
        private bool isSendable;

        public EBookBuilder SetPrice(decimal price)
        {
            this.price = price;
            return this;
        }

        public EBookBuilder SetSendable(bool isSendable)
        {
            this.isSendable = isSendable;
            return this;
        }

        public override EBook Build()
        {
            return new EBook(isbn, title, publishedYear, author, price, isSendable);
        }
    }
}
