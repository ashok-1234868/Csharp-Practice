using BookBorrowing.Business;
using BookBorrowing.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BookBorrowing.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddDbContext<BookDbContext>(options => options.UseSqlServer("Server=DESKTOP-U3D63PP\\SQLEXPRESS;Database=BookDb;Trusted_Connection=True;Encrypt=False;"));

            services.AddScoped<BookRepository>();
            services.AddScoped<LibraryServices>();

            var provider = services.BuildServiceProvider();
            var library=provider.GetRequiredService<LibraryServices>();

            while (true)
            {
                Console.WriteLine("\n1.Add Book. \n2.Borrow Book. \n3.Return Book. \n4.View Available Books. \n5.Exit.");
                Console.Write("Enter Your Choice :");
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        Console.Write("Title :");
                        string title= Console.ReadLine().Trim();

                        Console.Write("Author :");
                        string author= Console.ReadLine().Trim();

                        library.AddBook(title, author);
                        Console.WriteLine("Book Added.");
                        break;
                    case "2":
                        Console.Write("Enter title to borrow :");
                        string borrowtitle = Console.ReadLine().Trim();

                        if (library.BorrowBook(borrowtitle))
                            Console.WriteLine("Book borrowed.");
                        else
                            Console.WriteLine("Book not available.");
                        break;
                    case "3":
                        Console.Write("Enter title to return :");
                        string returntitle = Console.ReadLine().Trim();

                        if (library.ReturnBook(returntitle))
                            Console.WriteLine("Book returned.");
                        else
                            Console.WriteLine("Book not found or not borrowed.");
                        break;
                    case "4":
                        var books = library.ViewAvailableBooks();
                        if(books==null)
                        foreach (var book in books)
                        {
                            Console.WriteLine($"\nTitle :{book.Title}\nAuthor :{book.Author}");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Goodbye..!");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;


                }

            }

        }
    }
}
