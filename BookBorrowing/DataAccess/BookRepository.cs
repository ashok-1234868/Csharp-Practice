using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBorrowing.Models;
using BookBorrowing.DataAccess;
using BookBorrowing.Presentation;

namespace BookBorrowing.DataAccess
{
    public  class BookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }
        public void Addbook(Book book )
        {
            _context.BookTb.Add(book);
        }

        public List<Book> GetAvailableBooks()=>_context.BookTb.Where(b=>!b.IsBorrowed).ToList();

        public Book? GetBookByTitle(string title)=>_context.BookTb.Where(a=>a.Title==title).FirstOrDefault();

        public void SaveChanges() => _context.SaveChanges();

    }
}
