using App1.AbstractTypes;
using App1.BuilderPattern;
using App1.Enums;
using App1.Exceptions;
using App1.Logic;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();

            try
            {
                Book paperBook = new PaperBookBuilder()
                    .SetISBN("PB001")
                    .SetTitle("Clean Code")
                    .SetAuthor("Robert C. Martin")
                    .SetPublishedYear(2008)
                    .SetPrice(450)
                    .SetStock(15)
                    .SetShippable(true)
                    .Build();

                Book paperBook2 = new PaperBookBuilder()
                .SetISBN("PB002")
                .SetTitle("The Pragmatic Programmer")
                .SetAuthor("Andrew Hunt")
                .SetPublishedYear(2010)
                .SetPrice(500)
                .SetStock(13)
                .SetShippable(false)
                .Build();

                Book ebook = new EBookBuilder()
                    .SetISBN("EB01")
                    .SetTitle("C# in Depth")
                    .SetAuthor("Jon Skeet")
                    .SetPublishedYear(2019)
                    .SetPrice(299)
                    .SetSendable(true)
                    .Build();

                Book ebook2 = new EBookBuilder()
                .SetISBN("EB02")
                .SetTitle("Effective Java")
                .SetAuthor("Joshua Bloch")
                .SetPublishedYear(2018)
                .SetPrice(350)
                .SetSendable(false)
                .Build();

                Book demoBook = new DemoBookBuilder()
                    .SetISBN("DB1")
                    .SetTitle("Preview: Quantum Book")
                    .SetAuthor("Internal")
                    .SetPublishedYear(2015)
                    .SetFileType(FileType.Pdf)
                    .Build();

                Book demoBook2 = new DemoBookBuilder()
                .SetISBN("DB2")
                .SetTitle("Sample Java Patterns")
                .SetAuthor("Demo Team")
                .SetPublishedYear(2021)
                .SetFileType(FileType.Word)
                .Build();

                inventory.AddBook(paperBook);
                inventory.AddBook(paperBook2);

                inventory.AddBook(ebook);
                inventory.AddBook(ebook2);

                inventory.AddBook(demoBook);
                inventory.AddBook(demoBook2);


                Console.WriteLine();

                Console.WriteLine("Quantum book store: Buying Paper Book...");
                inventory.BuyBook(paperBook, 2); 

                Console.WriteLine();

                Console.WriteLine("Quantum book store: Buying EBook...");
                inventory.BuyBook(ebook, 1); 

                Console.WriteLine();

                Console.WriteLine("Quantum book store: Trying to buy Demo Book (not for sale)...");
                inventory.BuyBook(demoBook, 1);
            }

            catch (BookAlreadyExistsException ex) 
            {
                Console.WriteLine(ex.Message); 
            }

            catch (BookNotForSaleException ex) 
            {
                Console.WriteLine(ex.Message); 
            }

            catch (OutOfStockException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            catch (MissingShippingAddressException ex)
            {
                Console.WriteLine(ex.Message); 
            }

            catch (InvalidEmailException ex) 
            {
                Console.WriteLine(ex.Message); 
            }

            catch (Exception ex) 
            {
                Console.WriteLine($"Quantum book store: Unexpected error - {ex.Message}"); 
            }

            Console.WriteLine();
            Console.WriteLine("Quantum book store: Removing outdated books (older than 10 years)...");
            var removed = inventory.RemoveOutdatedBooks(10);
            Console.WriteLine($"Quantum book store: Total removed = {removed.Count}");

            Console.WriteLine();
            Console.WriteLine("Quantum book store: Press any key to exit.");
            Console.ReadKey();
        }
    }
}
