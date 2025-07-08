using App1.AbstractTypes;
using App1.Enums;

namespace App1.ConcreateTypes
{
    public class DemoBook : Book
    {
        public FileType FileType { get; set; }
        public DemoBook(string isbn, string title, int year, string author, FileType fileType)
        : base(isbn, title, year, author)
        {
            FileType = fileType;
        }
    }
}
