using Library.Application.Services.Interfaces;
using Library.Application.ViewModels;
using System.Collections.Generic;

namespace Library.Application.Services.Implementations
{
    public class BookService : IBookService
    {
        public int Create(NewBookInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<BookViewModel> GetBooks(string query)
        {
            throw new System.NotImplementedException();
        }

        public BookDetailsViewModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UpdateBookInputModel inputModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
