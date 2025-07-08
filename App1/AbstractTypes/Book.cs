namespace App1.AbstractTypes
{
    public abstract class Book
    {
        public string ISBN { get;set; }
        public string Title {  get; set; }
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        protected Book(string isbn, string title, int publishedYear, string author)
        {
            ISBN = isbn;
            Title = title;
            PublishedYear = publishedYear;
            Author = author;
        }
    }
}
