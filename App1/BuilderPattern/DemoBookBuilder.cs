using App1.ConcreateTypes;
using App1.Enums;

namespace App1.BuilderPattern
{
    public class DemoBookBuilder : BookBuilder<DemoBookBuilder, DemoBook>
    {
        private FileType fileType;

        public DemoBookBuilder SetFileType(FileType fileType)
        {
            this.fileType = fileType;
            return this;
        }

        public override DemoBook Build()
        {
            return new DemoBook(isbn, title, publishedYear, author, fileType);
        }
    }
}
