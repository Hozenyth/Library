using Library.Application.Services.Interfaces;
using Library.Application.ViewModels;
using Library.Core.Entities;
using Library.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Library.Application.Services.Implementations
{
    public class BookService : IBookService

    {
        private readonly LibraryDbContext _dbContext;
        public BookService(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(NewBookInputModel inputModel)
        {
            var book = new Book(inputModel.Title, inputModel.Author, inputModel.Isbn, inputModel.Year);
            _dbContext.Books.Add(book);
            
            return book.Id;
        }
       
        public void Delete(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == id);

            book.Cancel();
        }

        public void Delivery(int id)
        {
            var book = _dbContext.Books.SingleOrDefault(b => b.Id == id);

            book.Finish();
        }

        public List<BookViewModel> GetBooks(string query)
        {
            var books = _dbContext.Books;

            var booksViewModel = books
                .Select(x => new BookViewModel(x.Title, x.CreatedAd, x.Isbn))
                .ToList();

            return booksViewModel;
        }
      
        public BookDetailsViewModel GetByIsbn(string isbn)
        {

            var book = _dbContext.Books.SingleOrDefault(x => x.Isbn == isbn);

            if (book == null)
                return null;

            var bookDetailsViewModel = new BookDetailsViewModel(
                book.Id,
                book.Title,
                book.Author,
                book.Isbn,
                book.Year,
                book.Status

                );

            return bookDetailsViewModel;
        }

        public void LoanStart(int id)
        {
           var book = _dbContext.Books.SingleOrDefault( x => x.Id == id);

            book.Start();
        }

        public void Update(UpdateBookInputModel inputModel)
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == inputModel.Id);

            book.Update(inputModel.Title, inputModel.Author);
        }
    }
}
