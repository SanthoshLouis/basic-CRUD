using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiPractice5.Services;
using WebApiPractice5.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPractice5.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        public BookService _service;
        public BooksController(BookService service)
        {
            _service = service;
        }
        // GET: api/values---------------------
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _service.GetBooks();
        }
        //GET--------------------------------------------------------
        
        
        // POST api/values
        [HttpPost]
        public void PostTheDetailsOfBook([FromBody]Book somebook)
        {
            _service.PostTheDetailsOfBook(somebook);
        }
        //POST-------------------------------------------------------------

        
        // PUT api/values/5--------
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Book value)
        {
            _service.editBook(id, value);
        }

        [HttpGet("{id}")]//9
        public Book GetById(int id)
        {
            return _service.GetBookById(id);
        }
        //PUT-------------------------------------------------------------


        // DELETE api/values/5-------------
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.DeleteSomeBook(id);
        }
        // DELETE -----------------------------------------------------
    }
}
