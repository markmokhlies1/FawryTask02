using App1.AbstractTypes;

namespace App1.BuilderPattern
{
    public abstract class BookBuilder<TBuilder, TBook>
    where TBuilder : BookBuilder<TBuilder, TBook>
    where TBook : Book
    {
        protected string isbn;
        protected string title;
        protected int publishedYear;
        protected string author;

        public TBuilder SetISBN(string isbn)
        {
            this.isbn = isbn;
            return (TBuilder)this;
        }

        public TBuilder SetTitle(string title)
        {
            this.title = title;
            return (TBuilder)this;
        }

        public TBuilder SetPublishedYear(int year)
        {
            publishedYear = year;
            return (TBuilder)this;
        }

        public TBuilder SetAuthor(string author)
        {
            this.author = author;
            return (TBuilder)this;
        }

        public abstract TBook Build();
    }
}
