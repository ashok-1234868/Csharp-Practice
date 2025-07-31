using BookBorrowing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowing.DataAccess
{
    public  class BookDbContext:DbContext
    {
        public DbSet<Book> BookTb { get; set; }

        public BookDbContext() { }
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-U3D63PP\\SQLEXPRESS;Database=BookDb;Trusted_Connection=True;Encrypt=False;");
            }
        }

    }
}
