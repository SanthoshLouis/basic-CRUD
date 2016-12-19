using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice5.Data;
using WebApiPractice5.Models;

namespace WebApiPractice5.Infrastructure
{
    public class BookRepo
    {
        //field
        private ApplicationDbContext _db;

        //constructor

        public BookRepo (ApplicationDbContext db)
        {
            _db = db;
        }
        //method--get
        public IQueryable<Book> GetAllBooks()
        {
            return from b in _db.Books select b;
        }
        //method--post
        public void PostTheDetailsOfBook(Book specificbook)
        {
            _db.Books.Add(specificbook);
            _db.SaveChanges();

        }
        //two-methods--delete------------
        public void DeleteSpecificBook(Book id)
        {
            _db.Books.Remove(id);
            _db.SaveChanges();
        }
        public IQueryable<Book> GetBookById(int id)
        {
            return from b in _db.Books where b.Id == id select b;
        }

        //two-methods--delete-------------------------------------------

        //method-- edit-update------------

        public void EditBook(Book b)
        {

            _db.Books.Update(b);
            _db.SaveChanges();
        }

        //method-- edit-update--------------------------------------
    }
}
