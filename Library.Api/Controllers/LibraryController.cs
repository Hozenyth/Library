using FluentValidation;
using Library.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Library.Api.Controllers
{
    [Route("api/Library")]
    public class LibraryController : ControllerBase
    {
        
        [HttpGet] 
        public IActionResult GetBooks( string query)
        {
            //buscar todos os livros
            return Ok();
        }

      
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok();
        }
       
        [HttpGet("{isbn}")]
        public IActionResult GetBookByIsbn(int isbn)
        {
            return Ok();
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

       // [Route("api/DeleteBook")]
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {

            return NoContent();
        }


    }
}
