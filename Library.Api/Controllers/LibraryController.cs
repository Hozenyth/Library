using FluentValidation;
using Library.Api.Models;
using Library.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace Library.Api.Controllers
{
    [Route("api/Library")]
    public class LibraryController : ControllerBase
    {

        private readonly IBookService _bookservice;
        public LibraryController(IBookService bookService) 
        {
            _bookservice = bookService;

        }


        [HttpGet] 
        public IActionResult GetBooks( string query)
        {
            var books = _bookservice.GetBooks(query);
            
            return Ok(books);
        }
     

        [HttpGet("{isbn}")]       
        public IActionResult GetBookByIsbn(string isbn)
        {
            var book = _bookservice.GetByIsbn(isbn);
            
            if(book == null)              
                return NotFound();
            
            return Ok(book);
        }


        [HttpGet("{id:int}", Name = "GetOtherById")]
        public IActionResult GetBookById(int id)
        {
            var book = _bookservice.GetBookById(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }
        [HttpPost]
        public IActionResult CreateBook([FromBody] CreateBookModel createBook, [FromServices] IValidator<CreateBookModel> validator )
        {

            var result = validator.Validate(createBook);
            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
                return BadRequest(error);
            return Ok();
        }

     
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updateBook, [FromServices] IValidator<UpdateBookModel> validator)
        {
            var result = validator.Validate(updateBook);
            var error = result.Errors.Select(e => e.ErrorMessage);

            if (!result.IsValid)
                return BadRequest(error);

            return NoContent();
        }

      
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {

            return NoContent();
        }


    }
}
