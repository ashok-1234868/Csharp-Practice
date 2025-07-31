using BookBorrowing.DataAccess;
using BookBorrowing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowing.Business
{
    public  class LibraryServices
    {
        private readonly BookRepository _repository;

        public LibraryServices(BookRepository repository)
        {
            _repository = repository;
        }
        public void AddBook(string title, string author)
        {
            var book = new Book { Title = title, Author = author, IsBorrowed = false };
            _repository.Addbook(book);
            _repository.SaveChanges();
        }
        public List<Book> ViewAvailableBooks() => _repository.GetAvailableBooks();

        public bool BorrowBook(string title)
        {
            var book = _repository.GetBookByTitle(title);
            if (book == null || book.IsBorrowed) return false;
            book.IsBorrowed = true;
            _repository.SaveChanges();
            return true;
        }


        public bool ReturnBook(string title)
        {
            var book = _repository.GetBookByTitle(title);
            if (book == null || !book.IsBorrowed) return false;
            book.IsBorrowed = false;
            _repository.SaveChanges();
            return true;
        }


    }
}
