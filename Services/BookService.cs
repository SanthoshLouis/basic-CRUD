using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPractice5.Infrastructure;
using WebApiPractice5.Models;

namespace WebApiPractice5.Services
{
    public class BookService
    {
        //field
        private BookRepo _repo;
        //constructor
        public BookService(BookRepo repo)
        {
            _repo = repo;
        }
        //method-get----
        public IEnumerable<Book> GetBooks()
        {
            return _repo.GetAllBooks();
        }
        //method-get-----------------------------------------

        
        //method--post-----
        public void PostTheDetailsOfBook(Book somebook)
        {
            _repo.PostTheDetailsOfBook(somebook);
        }
        //method--post--------------------------------------------

        //for delete--------
        public void DeleteSomeBook(int id)
        {
            var anybook = _repo.GetBookById(id).FirstOrDefault();
            _repo.DeleteSpecificBook(anybook);
        }
        //for delete------------------------------------------------

        //method-- edit-update---------
        public void editBook(int id, Book bkk)//6
        {
            var bk = _repo.GetBookById(id).FirstOrDefault();
            bk.Author = bkk.Author;
            bk.Title = bkk.Title;
            _repo.EditBook(bk);
        }

        public Book GetBookById(int id)//10
        {
            return _repo.GetBookById(id).FirstOrDefault();
        }
        //method-- edit-update----------------------------------------------
    }
}
